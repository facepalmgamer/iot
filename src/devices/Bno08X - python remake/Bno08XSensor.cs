using System.Linq;
using System;

namespace Iot.Device.Bno08X
{

    // using pack_into = @struct.pack_into;

    //using i2c_device = adafruit_bus_device.i2c_device;


    public static partial class Module
    {


        public const int _BNO08X_DEFAULT_ADDRESS = 0x4A;

        // Library for the BNO08x IMUs from Hillcrest Laboratories
        // 
        //     :param ~busio.I2C i2c_bus: The I2C bus the BNO08x is connected to.
        // 
        //     
        public class BNO08X_I2C
            : BNO08X
        {

            public BNO08X_I2C(object i2c_bus, object reset = null, int address = _BNO08X_DEFAULT_ADDRESS, bool debug = false)
            {
                this.bus_device_obj = i2c_device.I2CDevice(i2c_bus, address);
                base.@__init__(reset, debug);
            }

            public virtual object _send_packet(object channel, object data)
            {
                var data_length = data.Count;
                var write_length = data_length + 4;
                pack_into("<H", this._data_buffer, 0, write_length);
                this._data_buffer[2] = channel;
                this._data_buffer[3] = this._sequence_number[channel];
                foreach (var _tup_1 in data.Select((_p_1, _p_2) => Tuple.Create(_p_2, _p_1)))
                {
                    var idx = _tup_1.Item1;
                    var send_byte = _tup_1.Item2;
                    this._data_buffer[4 + idx] = send_byte;
                }
                var packet = Packet(this._data_buffer);
                this._dbg("Sending packet:");
                this._dbg(packet);
                using (var i2c = this.bus_device_obj)
                {
                    i2c.write(this._data_buffer, end: write_length);
                }
                this._sequence_number[channel] = (this._sequence_number[channel] + 1) % 256;
                return this._sequence_number[channel];
            }

            // returns true if available data was read
            // the sensor will always tell us how much there is, so no need to track it ourselves
            // Reads the first 4 bytes available as a header
            public virtual object _read_header()
            {
                using (var i2c = this.bus_device_obj)
                {
                    i2c.readinto(this._data_buffer, end: 4);
                }
                var packet_header = Packet.header_from_buffer(this._data_buffer);
                this._dbg(packet_header);
                return packet_header;
            }

            public virtual object _read_packet()
            {
                using (var i2c = this.bus_device_obj)
                {
                    i2c.readinto(this._data_buffer, end: 4);
                }
                this._dbg("");
                // print("SHTP READ packet header: ", [hex(x) for x in self._data_buffer[0:4]])
                var header = Packet.header_from_buffer(this._data_buffer);
                var packet_byte_count = header.packet_byte_count;
                var channel_number = header.channel_number;
                var sequence_number = header.sequence_number;
                this._sequence_number[channel_number] = sequence_number;
                if (packet_byte_count == 0)
                {
                    this._dbg("SKIPPING NO PACKETS AVAILABLE IN i2c._read_packet");
                    throw PacketError("No packet available");
                }
                packet_byte_count -= 4;
                this._dbg("channel", channel_number, "has", packet_byte_count, "bytes available to read");
                this._read(packet_byte_count);
                var new_packet = Packet(this._data_buffer);
                if (this._debug)
                {
                    Console.WriteLine(new_packet);
                }
                this._update_sequence_number(new_packet);
                return new_packet;
            }

            // returns true if all requested data was read
            public virtual object _read(object requested_read_length)
            {
                this._dbg("trying to read", requested_read_length, "bytes");
                // +4 for the header
                var total_read_length = requested_read_length + 4;
                if (total_read_length > DATA_BUFFER_SIZE)
                {
                    this._data_buffer = bytearray(total_read_length);
                    this._dbg(String.Format("!!!!!!!!!!!! ALLOCATION: increased _data_buffer to bytearray(%d) !!!!!!!!!!!!! ", total_read_length));
                }
                using (var i2c = this.bus_device_obj)
                {
                    i2c.readinto(this._data_buffer, end: total_read_length);
                }
            }

            public object _data_ready
            {
                get
                {
                    object ready;
                    var header = this._read_header();
                    if (header.channel_number > 5)
                    {
                        this._dbg("channel number out of range:", header.channel_number);
                    }
                    if (header.packet_byte_count == 0x7FFF)
                    {
                        Console.WriteLine("Byte count is 0x7FFF/0xFFFF; Error?");
                        if (header.sequence_number == 0xFF)
                        {
                            Console.WriteLine("Sequence number is 0xFF; Error?");
                        }
                        ready = false;
                    }
                    else
                    {
                        ready = header.data_length > 0;
                    }
                    // self._dbg("\tdata ready", ready)
                    return ready;
                }
            }
        }
    }
}
