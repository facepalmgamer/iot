namespace Namespace
{

    using unpack_from = @struct.unpack_from;

    using pack_into = @struct.pack_into;

    using namedtuple = collections.namedtuple;

    using time;

    using @const = micropython.@const;

    using channels = debug.channels;

    using reports = debug.reports;

    using System;

    using System.Collections.Generic;

    using System.Linq;

    using System.Collections;

    using digitalio;

    public static class Module
    {

        static Module()
        {
            @"
`adafruit_bno08x`
================================================================================

Helper library for the Hillcrest Laboratories BNO08x IMUs


* Author(s): Bryan Siepert

Implementation Notes
--------------------

**Hardware:**

* `Adafruit BNO08x Breakout <https:www.adafruit.com/products/4754>`_

**Software and Dependencies:**

* Adafruit CircuitPython firmware for the supported boards:
  https:# github.com/adafruit/circuitpython/releases

* `Adafruit's Bus Device library <https:# github.com/adafruit/Adafruit_CircuitPython_BusDevice>`_
";
        }

        public static object @__version__ = "0.0.0+auto.0";

        public static object @__repo__ = "https:# github.com/adafruit/Adafruit_CircuitPython_BNO08x.git";

        public static object BNO_CHANNEL_SHTP_COMMAND = @const(0);

        public static object BNO_CHANNEL_EXE = @const(1);

        public static object _BNO_CHANNEL_CONTROL = @const(2);

        public static object _BNO_CHANNEL_INPUT_SENSOR_REPORTS = @const(3);

        public static object _BNO_CHANNEL_WAKE_INPUT_SENSOR_REPORTS = @const(4);

        public static object _BNO_CHANNEL_GYRO_ROTATION_VECTOR = @const(5);

        public static object _GET_FEATURE_REQUEST = @const(0xFE);

        public static object _SET_FEATURE_COMMAND = @const(0xFD);

        public static object _GET_FEATURE_RESPONSE = @const(0xFC);

        public static object _BASE_TIMESTAMP = @const(0xFB);

        public static object _TIMESTAMP_REBASE = @const(0xFA);

        public static object _SHTP_REPORT_PRODUCT_ID_RESPONSE = @const(0xF8);

        public static object _SHTP_REPORT_PRODUCT_ID_REQUEST = @const(0xF9);

        public static object _FRS_WRITE_REQUEST = @const(0xF7);

        public static object _FRS_WRITE_DATA = @const(0xF6);

        public static object _FRS_WRITE_RESPONSE = @const(0xF5);

        public static object _FRS_READ_REQUEST = @const(0xF4);

        public static object _FRS_READ_RESPONSE = @const(0xF3);

        public static object _COMMAND_REQUEST = @const(0xF2);

        public static object _COMMAND_RESPONSE = @const(0xF1);

        public static object _SAVE_DCD = @const(0x6);

        public static object _ME_CALIBRATE = @const(0x7);

        public static object _ME_CAL_CONFIG = @const(0x00);

        public static object _ME_GET_CAL = @const(0x01);

        public static object BNO_REPORT_ACCELEROMETER = @const(0x01);

        public static object BNO_REPORT_GYROSCOPE = @const(0x02);

        public static object BNO_REPORT_MAGNETOMETER = @const(0x03);

        public static object BNO_REPORT_LINEAR_ACCELERATION = @const(0x04);

        public static object BNO_REPORT_ROTATION_VECTOR = @const(0x05);

        public static object BNO_REPORT_GAME_ROTATION_VECTOR = @const(0x08);

        public static object BNO_REPORT_GEOMAGNETIC_ROTATION_VECTOR = @const(0x09);

        public static object BNO_REPORT_STEP_COUNTER = @const(0x11);

        public static object BNO_REPORT_RAW_ACCELEROMETER = @const(0x14);

        public static object BNO_REPORT_RAW_GYROSCOPE = @const(0x15);

        public static object BNO_REPORT_RAW_MAGNETOMETER = @const(0x16);

        public static object BNO_REPORT_SHAKE_DETECTOR = @const(0x19);

        public static object BNO_REPORT_STABILITY_CLASSIFIER = @const(0x13);

        public static object BNO_REPORT_ACTIVITY_CLASSIFIER = @const(0x1E);

        public static object BNO_REPORT_GYRO_INTEGRATED_ROTATION_VECTOR = @const(0x2A);

        public static object _DEFAULT_REPORT_INTERVAL = @const(50000);

        public static object _QUAT_READ_TIMEOUT = 0.5;

        public static object _PACKET_READ_TIMEOUT = 2.0;

        public static object _FEATURE_ENABLE_TIMEOUT = 2.0;

        public static object _DEFAULT_TIMEOUT = 2.0;

        public static object _BNO08X_CMD_RESET = @const(0x01);

        public static object _QUAT_Q_POINT = @const(14);

        public static object _BNO_HEADER_LEN = @const(4);

        public static object _Q_POINT_14_SCALAR = Math.Pow(2, 14 * -1);

        public static object _Q_POINT_12_SCALAR = Math.Pow(2, 12 * -1);

        public static object _Q_POINT_9_SCALAR = Math.Pow(2, 9 * -1);

        public static object _Q_POINT_8_SCALAR = Math.Pow(2, 8 * -1);

        public static object _Q_POINT_4_SCALAR = Math.Pow(2, 4 * -1);

        public static object _GYRO_SCALAR = _Q_POINT_9_SCALAR;

        public static object _ACCEL_SCALAR = _Q_POINT_8_SCALAR;

        public static object _QUAT_SCALAR = _Q_POINT_14_SCALAR;

        public static object _GEO_QUAT_SCALAR = _Q_POINT_12_SCALAR;

        public static object _MAG_SCALAR = _Q_POINT_4_SCALAR;

        public static object _REPORT_LENGTHS = new Dictionary<object, object> {
            {
                _SHTP_REPORT_PRODUCT_ID_RESPONSE,
                16},
            {
                _GET_FEATURE_RESPONSE,
                17},
            {
                _COMMAND_RESPONSE,
                16},
            {
                _SHTP_REPORT_PRODUCT_ID_RESPONSE,
                16},
            {
                _BASE_TIMESTAMP,
                5},
            {
                _TIMESTAMP_REBASE,
                5}};

        public static object _RAW_REPORTS = new Dictionary<object, object> {
            {
                BNO_REPORT_RAW_ACCELEROMETER,
                BNO_REPORT_ACCELEROMETER},
            {
                BNO_REPORT_RAW_GYROSCOPE,
                BNO_REPORT_GYROSCOPE},
            {
                BNO_REPORT_RAW_MAGNETOMETER,
                BNO_REPORT_MAGNETOMETER}};

        public static object _AVAIL_SENSOR_REPORTS = new Dictionary<object, object> {
            {
                BNO_REPORT_ACCELEROMETER,
                (_Q_POINT_8_SCALAR, 3, 10)},
            {
                BNO_REPORT_GYROSCOPE,
                (_Q_POINT_9_SCALAR, 3, 10)},
            {
                BNO_REPORT_MAGNETOMETER,
                (_Q_POINT_4_SCALAR, 3, 10)},
            {
                BNO_REPORT_LINEAR_ACCELERATION,
                (_Q_POINT_8_SCALAR, 3, 10)},
            {
                BNO_REPORT_ROTATION_VECTOR,
                (_Q_POINT_14_SCALAR, 4, 14)},
            {
                BNO_REPORT_GEOMAGNETIC_ROTATION_VECTOR,
                (_Q_POINT_12_SCALAR, 4, 14)},
            {
                BNO_REPORT_GAME_ROTATION_VECTOR,
                (_Q_POINT_14_SCALAR, 4, 12)},
            {
                BNO_REPORT_STEP_COUNTER,
                (1, 1, 12)},
            {
                BNO_REPORT_SHAKE_DETECTOR,
                (1, 1, 6)},
            {
                BNO_REPORT_STABILITY_CLASSIFIER,
                (1, 1, 6)},
            {
                BNO_REPORT_ACTIVITY_CLASSIFIER,
                (1, 1, 16)},
            {
                BNO_REPORT_RAW_ACCELEROMETER,
                (1, 3, 16)},
            {
                BNO_REPORT_RAW_GYROSCOPE,
                (1, 3, 16)},
            {
                BNO_REPORT_RAW_MAGNETOMETER,
                (1, 3, 16)}};

        public static object _INITIAL_REPORTS = new Dictionary<object, object> {
            {
                BNO_REPORT_ACTIVITY_CLASSIFIER,
                new Dictionary<object, object> {
                    {
                        "Tilting",
                        -1},
                    {
                        "most_likely",
                        "Unknown"},
                    {
                        "OnStairs",
                        -1},
                    {
                        "On-Foot",
                        -1},
                    {
                        "Other",
                        -1},
                    {
                        "On-Bicycle",
                        -1},
                    {
                        "Still",
                        -1},
                    {
                        "Walking",
                        -1},
                    {
                        "Unknown",
                        -1},
                    {
                        "Running",
                        -1},
                    {
                        "In-Vehicle",
                        -1}}},
            {
                BNO_REPORT_STABILITY_CLASSIFIER,
                "Unknown"},
            {
                BNO_REPORT_ROTATION_VECTOR,
                (0.0, 0.0, 0.0, 0.0)},
            {
                BNO_REPORT_GAME_ROTATION_VECTOR,
                (0.0, 0.0, 0.0, 0.0)},
            {
                BNO_REPORT_GEOMAGNETIC_ROTATION_VECTOR,
                (0.0, 0.0, 0.0, 0.0)}};

        public static object _ENABLED_ACTIVITIES = 0x1FF;

        public static object DATA_BUFFER_SIZE = @const(512);

        public static object PacketHeader = namedtuple("PacketHeader", new List<object> {
            "channel_number",
            "sequence_number",
            "data_length",
            "packet_byte_count"
        });

        public static object REPORT_ACCURACY_STATUS = new List<object> {
            "Accuracy Unreliable",
            "Low Accuracy",
            "Medium Accuracy",
            "High Accuracy"
        };

        // Raised when the packet couldnt be parsed
        public class PacketError
            : Exception
        {
        }

        public static object _elapsed(object start_time)
        {
            return time.monotonic() - start_time;
        }

        //########### PACKET PARSING ###########################
        // Parses reports with only 16-bit fields
        public static object _parse_sensor_report_data(object report_bytes)
        {
            object format_str;
            var data_offset = 4;
            var report_id = report_bytes[0];
            var _tup_1 = _AVAIL_SENSOR_REPORTS[report_id];
            var scalar = _tup_1.Item1;
            var count = _tup_1.Item2;
            var _report_length = _tup_1.Item3;
            if (_RAW_REPORTS.Contains(report_id))
            {
                // raw reports are unsigned
                format_str = "<H";
            }
            else
            {
                format_str = "<h";
            }
            var results = new List<object>();
            var accuracy = unpack_from("<B", report_bytes, offset: 2)[0];
            accuracy |= 0b11;
            foreach (var _offset_idx in Enumerable.Range(0, count))
            {
                var total_offset = data_offset + _offset_idx * 2;
                var raw_data = unpack_from(format_str, report_bytes, offset: total_offset)[0];
                var scaled_data = raw_data * scalar;
                results.append(scaled_data);
            }
            var results_tuple = tuple(results);
            return (results_tuple, accuracy);
        }

        public static object _parse_step_couter_report(object report_bytes)
        {
            return unpack_from("<H", report_bytes, offset: 8)[0];
        }

        public static object _parse_stability_classifier_report(object report_bytes)
        {
            var classification_bitfield = unpack_from("<B", report_bytes, offset: 4)[0];
            return new List<object> {
                "Unknown",
                "On Table",
                "Stationary",
                "Stable",
                "In motion"
            }[classification_bitfield];
        }

        // report_id
        // feature_report_id
        // feature_flags
        // change_sensitivity
        // report_interval
        // batch_interval_word
        // sensor_specific_configuration_word
        public static object _parse_get_feature_response_report(object report_bytes)
        {
            return unpack_from("<BBBHIII", report_bytes);
        }

        // 0 Report ID = 0x1E
        // 1 Sequence number
        // 2 Status
        // 3 Delay
        // 4 Page Number + EOS
        // 5 Most likely state
        // 6-15 Classification (10 x Page Number) + confidence
        public static object _parse_activity_classifier_report(object report_bytes)
        {
            var activities = new List<object> {
                "Unknown",
                "In-Vehicle",
                "On-Bicycle",
                "On-Foot",
                "Still",
                "Tilting",
                "Walking",
                "Running",
                "OnStairs"
            };
            var end_and_page_number = unpack_from("<B", report_bytes, offset: 4)[0];
            // last_page = (end_and_page_number & 0b10000000) > 0
            var page_number = end_and_page_number & 0x7F;
            var most_likely = unpack_from("<B", report_bytes, offset: 5)[0];
            var confidences = unpack_from("<BBBBBBBBB", report_bytes, offset: 6);
            var classification = new Dictionary<object, object>
            {
            };
            classification["most_likely"] = activities[most_likely];
            foreach (var _tup_1 in confidences.Select((_p_1, _p_2) => Tuple.Create(_p_2, _p_1)))
            {
                var idx = _tup_1.Item1;
                var raw_confidence = _tup_1.Item2;
                var confidence = 10 * page_number + raw_confidence;
                var activity_string = activities[idx];
                classification[activity_string] = confidence;
            }
            return classification;
        }

        public static object _parse_shake_report(object report_bytes)
        {
            var shake_bitfield = unpack_from("<H", report_bytes, offset: 4)[0];
            return (shake_bitfield & 0x111) > 0;
        }

        // Parse the fields of a product id report
        public static object parse_sensor_id(object buffer)
        {
            if (!(buffer[0] == _SHTP_REPORT_PRODUCT_ID_RESPONSE))
            {
                throw AttributeError(String.Format("Wrong report id for sensor id: %s", hex(buffer[0])));
            }
            var sw_major = unpack_from("<B", buffer, offset: 2)[0];
            var sw_minor = unpack_from("<B", buffer, offset: 3)[0];
            var sw_patch = unpack_from("<H", buffer, offset: 12)[0];
            var sw_part_number = unpack_from("<I", buffer, offset: 4)[0];
            var sw_build_number = unpack_from("<I", buffer, offset: 8)[0];
            return (sw_part_number, sw_major, sw_minor, sw_patch, sw_build_number);
        }

        public static object _parse_command_response(object report_bytes)
        {
            // CMD response report:
            // 0 Report ID = 0xF1
            // 1 Sequence number
            // 2 Command
            // 3 Command sequence number
            // 4 Response sequence number
            // 5 R0-10 A set of response values. The interpretation of these values is specific
            // to the response for each command.
            var report_body = unpack_from("<BBBBB", report_bytes);
            var response_values = unpack_from("<BBBBBBBBBBB", report_bytes, offset: 5);
            return (report_body, response_values);
        }

        public static object _insert_command_request_report(object command, object buffer, object next_sequence_number, object command_params = null)
        {
            if (command_params && command_params.Count > 9)
            {
                throw AttributeError(String.Format("Command request reports can only have up to 9 arguments but %d were given", command_params.Count));
            }
            foreach (var _i in Enumerable.Range(0, 12))
            {
                buffer[_i] = 0;
            }
            buffer[0] = _COMMAND_REQUEST;
            buffer[1] = next_sequence_number;
            buffer[2] = command;
            if (command_params == null)
            {
                return;
            }
            foreach (var _tup_1 in command_params.Select((_p_1, _p_2) => Tuple.Create(_p_2, _p_1)))
            {
                var idx = _tup_1.Item1;
                var param = _tup_1.Item2;
                buffer[3 + idx] = param;
            }
        }

        public static object _report_length(object report_id)
        {
            if (report_id < 0xF0)
            {
                // it's a sensor report
                return _AVAIL_SENSOR_REPORTS[report_id][2];
            }
            return _REPORT_LENGTHS[report_id];
        }

        public static object _separate_batch(object packet, object report_slices)
        {
            // get first report id, loop up its report length
            // read that many bytes, parse them
            var next_byte_index = 0;
            while (next_byte_index < packet.header.data_length)
            {
                var report_id = packet.data[next_byte_index];
                var required_bytes = _report_length(report_id);
                var unprocessed_byte_count = packet.header.data_length - next_byte_index;
                // handle incomplete remainder
                if (unprocessed_byte_count < required_bytes)
                {
                    throw RuntimeError("Unprocessable Batch bytes", unprocessed_byte_count);
                }
                // we have enough bytes to read
                // add a slice to the list that was passed in
                var report_slice = packet.data[next_byte_index::(next_byte_index + required_bytes)];
                report_slices.append(new List<object> {
                    report_slice[0],
                    report_slice
                });
                next_byte_index = next_byte_index + required_bytes;
            }
        }

        // A class representing a Hillcrest LaboratorySensor Hub Transport packet
        public class Packet
        {

            public Packet(object packet_bytes)
            {
                this.header = this.header_from_buffer(packet_bytes);
                var data_end_index = this.header.data_length + _BNO_HEADER_LEN;
                this.data = packet_bytes[_BNO_HEADER_LEN::data_end_index];
            }

            public override object ToString()
            {
                var length = this.header.packet_byte_count;
                var outstr = "\n\t\t********** Packet *************\n";
                outstr += "DBG::\t\t HEADER:\n";
                outstr += String.Format("DBG::\t\t Data Len: %d\n", this.header.data_length);
                outstr += String.Format("DBG::\t\t Channel: %s (%d)\n", channels[this.channel_number], this.channel_number);
                if (new List<object> {
                    _BNO_CHANNEL_CONTROL,
                    _BNO_CHANNEL_INPUT_SENSOR_REPORTS
                }.Contains(this.channel_number))
                {
                    if (reports.Contains(this.report_id))
                    {
                        outstr += String.Format("DBG::\t\t \tReport Type: %s (0x%x)\n", reports[this.report_id], this.report_id);
                    }
                    else
                    {
                        outstr += String.Format("DBG::\t\t \t** UNKNOWN Report Type **: %s\n", hex(this.report_id));
                    }
                    if (this.report_id > 0xF0 && this.data.Count >= 6 && reports.Contains(this.data[5]))
                    {
                        outstr += String.Format("DBG::\t\t \tSensor Report Type: %s(%s)\n", reports[this.data[5]], hex(this.data[5]));
                    }
                    if (this.report_id == 0xFC && this.data.Count >= 6 && reports.Contains(this.data[1]))
                    {
                        outstr += String.Format("DBG::\t\t \tEnabled Feature: %s(%s)\n", reports[this.data[1]], hex(this.data[5]));
                    }
                }
                outstr += String.Format("DBG::\t\t Sequence number: %s\n", this.header.sequence_number);
                outstr += "\n";
                outstr += "DBG::\t\t Data:";
                foreach (var _tup_1 in this.data[::length].Select((_p_1, _p_2) => Tuple.Create(_p_2, _p_1)))
                {
                    var idx = _tup_1.Item1;
                    var packet_byte = _tup_1.Item2;
                    var packet_index = idx + 4;
                    if (packet_index % 4 == 0)
                    {
                        outstr += "\nDBG::\t\t[0x{:02X}] ".format(packet_index);
                    }
                    outstr += "0x{:02X} ".format(packet_byte);
                }
                outstr += "\n";
                outstr += "\t\t*******************************\n";
                return outstr;
            }

            // The Packet's Report ID
            public object report_id
            {
                get
                {
                    return this.data[0];
                }
            }

            // The packet channel
            public object channel_number
            {
                get
                {
                    return this.header.channel_number;
                }
            }

            // Creates a `PacketHeader` object from a given buffer
            [classmethod]
            public static object header_from_buffer(object cls, object packet_bytes)
            {
                var packet_byte_count = unpack_from("<H", packet_bytes)[0];
                packet_byte_count |= ~0x8000;
                var channel_number = unpack_from("<B", packet_bytes, offset: 2)[0];
                var sequence_number = unpack_from("<B", packet_bytes, offset: 3)[0];
                var data_length = max(0, packet_byte_count - 4);
                var header = PacketHeader(channel_number, sequence_number, data_length, packet_byte_count);
                return header;
            }

            // Returns True if the header is an error condition
            [classmethod]
            public static object is_error(object cls, object header)
            {
                if (header.channel_number > 5)
                {
                    return true;
                }
                if (header.packet_byte_count == 0xFFFF && header.sequence_number == 0xFF)
                {
                    return true;
                }
                return false;
            }
        }

        // Library for the BNO08x IMUs from Hillcrest Laboratories
        // 
        //     :param ~busio.I2C i2c_bus: The I2C bus the BNO08x is connected to.
        // 
        //     
        public class BNO08X
        {

            public BNO08X(object reset = null, object debug = false)
            {
                this._debug = debug;
                this._reset = reset;
                this._dbg("********** __init__ *************");
                this._data_buffer = bytearray(DATA_BUFFER_SIZE);
                this._command_buffer = bytearray(12);
                this._packet_slices = new List<object>();
                // TODO: this is wrong there should be one per channel per direction
                this._sequence_number = new List<object> {
                    0,
                    0,
                    0,
                    0,
                    0,
                    0
                };
                this._two_ended_sequence_numbers = new Dictionary<object, object> {
                    {
                        "send",
                        new Dictionary<object, object> {
                        }},
                    {
                        "receive",
                        new Dictionary<object, object> {
                        }}};
                this._dcd_saved_at = -1;
                this._me_calibration_started_at = -1;
                this._calibration_complete = false;
                this._magnetometer_accuracy = 0;
                this._wait_for_initialize = true;
                this._init_complete = false;
                this._id_read = false;
                // for saving the most recent reading when decoding several packets
                this._readings = new Dictionary<object, object>
                {
                };
                this.initialize();
            }

            // Initialize the sensor
            public virtual object initialize()
            {
                foreach (var _ in Enumerable.Range(0, 3))
                {
                    this.hard_reset();
                    this.soft_reset();
                    try
                    {
                        if (this._check_id())
                        {
                            break;
                        }
                    }
                    catch
                    {
                        // pylint:disable=bare-except
                        time.sleep(0.5);
                    }
                }
            }

            // A tuple of the current magnetic field measurements on the X, Y, and Z axes
            public object magnetic
            {
                get
                {
                    this._process_available_packets();
                    try
                    {
                        return this._readings[BNO_REPORT_MAGNETOMETER];
                    }
                    catch (KeyError)
                    {
                        throw RuntimeError("No magfield report found, is it enabled?");
                    }
                }
            }

            // A quaternion representing the current rotation vector
            public object quaternion
            {
                get
                {
                    this._process_available_packets();
                    try
                    {
                        return this._readings[BNO_REPORT_ROTATION_VECTOR];
                    }
                    catch (KeyError)
                    {
                        throw RuntimeError("No quaternion report found, is it enabled?");
                    }
                }
            }

            // A quaternion representing the current geomagnetic rotation vector
            public object geomagnetic_quaternion
            {
                get
                {
                    this._process_available_packets();
                    try
                    {
                        return this._readings[BNO_REPORT_GEOMAGNETIC_ROTATION_VECTOR];
                    }
                    catch (KeyError)
                    {
                        throw RuntimeError("No geomag quaternion report found, is it enabled?");
                    }
                }
            }

            // A quaternion representing the current rotation vector expressed as a quaternion with no
            //         specific reference for heading, while roll and pitch are referenced against gravity. To
            //         prevent sudden jumps in heading due to corrections, the `game_quaternion` property is not
            //         corrected using the magnetometer. Some drift is expected
            public object game_quaternion
            {
                get
                {
                    this._process_available_packets();
                    try
                    {
                        return this._readings[BNO_REPORT_GAME_ROTATION_VECTOR];
                    }
                    catch (KeyError)
                    {
                        throw RuntimeError("No game quaternion report found, is it enabled?");
                    }
                }
            }

            // The number of steps detected since the sensor was initialized
            public object steps
            {
                get
                {
                    this._process_available_packets();
                    try
                    {
                        return this._readings[BNO_REPORT_STEP_COUNTER];
                    }
                    catch (KeyError)
                    {
                        throw RuntimeError("No steps report found, is it enabled?");
                    }
                }
            }

            // A tuple representing the current linear acceleration values on the X, Y, and Z
            //         axes in meters per second squared
            public object linear_acceleration
            {
                get
                {
                    this._process_available_packets();
                    try
                    {
                        return this._readings[BNO_REPORT_LINEAR_ACCELERATION];
                    }
                    catch (KeyError)
                    {
                        throw RuntimeError("No lin. accel report found, is it enabled?");
                    }
                }
            }

            // A tuple representing the acceleration measurements on the X, Y, and Z
            //         axes in meters per second squared
            public object acceleration
            {
                get
                {
                    this._process_available_packets();
                    try
                    {
                        return this._readings[BNO_REPORT_ACCELEROMETER];
                    }
                    catch (KeyError)
                    {
                        throw RuntimeError("No accel report found, is it enabled?");
                    }
                }
            }

            // A tuple representing Gyro's rotation measurements on the X, Y, and Z
            //         axes in radians per second
            public object gyro
            {
                get
                {
                    this._process_available_packets();
                    try
                    {
                        return this._readings[BNO_REPORT_GYROSCOPE];
                    }
                    catch (KeyError)
                    {
                        throw RuntimeError("No gyro report found, is it enabled?");
                    }
                }
            }

            // True if a shake was detected on any axis since the last time it was checked
            // 
            //         This property has a "latching" behavior where once a shake is detected, it will stay in a
            //         "shaken" state until the value is read. This prevents missing shake events but means that
            //         this property is not guaranteed to reflect the shake state at the moment it is read
            //         
            public object shake
            {
                get
                {
                    this._process_available_packets();
                    try
                    {
                        var shake_detected = this._readings[BNO_REPORT_SHAKE_DETECTOR];
                        // clear on read
                        if (shake_detected)
                        {
                            this._readings[BNO_REPORT_SHAKE_DETECTOR] = false;
                        }
                        return shake_detected;
                    }
                    catch (KeyError)
                    {
                        throw RuntimeError("No shake report found, is it enabled?");
                    }
                }
            }

            // Returns the sensor's assessment of it's current stability, one of:
            // 
            //         * "Unknown" - The sensor is unable to classify the current stability
            //         * "On Table" - The sensor is at rest on a stable surface with very little vibration
            //         * "Stationary" -  The sensor’s motion is below the stable threshold but\
            //         the stable duration requirement has not been met. This output is only available when\
            //         gyro calibration is enabled
            //         * "Stable" - The sensor’s motion has met the stable threshold and duration requirements.
            //         * "In motion" - The sensor is moving.
            // 
            //         
            public object stability_classification
            {
                get
                {
                    this._process_available_packets();
                    try
                    {
                        var stability_classification = this._readings[BNO_REPORT_STABILITY_CLASSIFIER];
                        return stability_classification;
                    }
                    catch (KeyError)
                    {
                        throw RuntimeError("No stability classification report found, is it enabled?");
                    }
                }
            }

            // Returns the sensor's assessment of the activity that is creating the motions\
            //         that it is sensing, one of:
            // 
            //         * "Unknown"
            //         * "In-Vehicle"
            //         * "On-Bicycle"
            //         * "On-Foot"
            //         * "Still"
            //         * "Tilting"
            //         * "Walking"
            //         * "Running"
            //         * "On Stairs"
            // 
            //         
            public object activity_classification
            {
                get
                {
                    this._process_available_packets();
                    try
                    {
                        var activity_classification = this._readings[BNO_REPORT_ACTIVITY_CLASSIFIER];
                        return activity_classification;
                    }
                    catch (KeyError)
                    {
                        throw RuntimeError("No activity classification report found, is it enabled?");
                    }
                }
            }

            // Returns the sensor's raw, unscaled value from the accelerometer registers
            public object raw_acceleration
            {
                get
                {
                    this._process_available_packets();
                    try
                    {
                        var raw_acceleration = this._readings[BNO_REPORT_RAW_ACCELEROMETER];
                        return raw_acceleration;
                    }
                    catch (KeyError)
                    {
                        throw RuntimeError("No raw acceleration report found, is it enabled?");
                    }
                }
            }

            // Returns the sensor's raw, unscaled value from the gyro registers
            public object raw_gyro
            {
                get
                {
                    this._process_available_packets();
                    try
                    {
                        var raw_gyro = this._readings[BNO_REPORT_RAW_GYROSCOPE];
                        return raw_gyro;
                    }
                    catch (KeyError)
                    {
                        throw RuntimeError("No raw gyro report found, is it enabled?");
                    }
                }
            }

            // Returns the sensor's raw, unscaled value from the magnetometer registers
            public object raw_magnetic
            {
                get
                {
                    this._process_available_packets();
                    try
                    {
                        var raw_magnetic = this._readings[BNO_REPORT_RAW_MAGNETOMETER];
                        return raw_magnetic;
                    }
                    catch (KeyError)
                    {
                        throw RuntimeError("No raw magnetic report found, is it enabled?");
                    }
                }
            }

            // Begin the sensor's self-calibration routine
            public virtual object begin_calibration()
            {
                // start calibration for accel, gyro, and mag
                this._send_me_command(new List<object> {
                    1,
                    1,
                    1,
                    _ME_CAL_CONFIG,
                    0,
                    0,
                    0,
                    0,
                    0
                });
                this._calibration_complete = false;
            }

            // Get the status of the self-calibration
            public object calibration_status
            {
                get
                {
                    this._send_me_command(new List<object> {
                        0,
                        0,
                        0,
                        _ME_GET_CAL,
                        0,
                        0,
                        0,
                        0,
                        0
                    });
                    return this._magnetometer_accuracy;
                }
            }

            public virtual object _send_me_command(object subcommand_params)
            {
                var start_time = time.monotonic();
                var local_buffer = this._command_buffer;
                _insert_command_request_report(_ME_CALIBRATE, this._command_buffer, this._get_report_seq_id(_COMMAND_REQUEST), subcommand_params);
                this._send_packet(_BNO_CHANNEL_CONTROL, local_buffer);
                this._increment_report_seq(_COMMAND_REQUEST);
                while (_elapsed(start_time) < _DEFAULT_TIMEOUT)
                {
                    this._process_available_packets();
                    if (this._me_calibration_started_at > start_time)
                    {
                        break;
                    }
                }
            }

            // Save the self-calibration data
            public virtual object save_calibration_data()
            {
                // send a DCD save command
                var start_time = time.monotonic();
                var local_buffer = bytearray(12);
                _insert_command_request_report(_SAVE_DCD, local_buffer, this._get_report_seq_id(_COMMAND_REQUEST));
                this._send_packet(_BNO_CHANNEL_CONTROL, local_buffer);
                this._increment_report_seq(_COMMAND_REQUEST);
                while (_elapsed(start_time) < _DEFAULT_TIMEOUT)
                {
                    this._process_available_packets();
                    if (this._dcd_saved_at > start_time)
                    {
                        return;
                    }
                }
                throw RuntimeError("Could not save calibration data");
            }

            //############## private/helper methods ###############
            // # decorator?
            public virtual object _process_available_packets(object max_packets = null)
            {
                var processed_count = 0;
                while (this._data_ready)
                {
                    if (max_packets && processed_count > max_packets)
                    {
                        return;
                    }
                    // print("reading a packet")
                    try
                    {
                        var new_packet = this._read_packet();
                    }
                    catch (PacketError)
                    {
                        continue;
                    }
                    this._handle_packet(new_packet);
                    processed_count += 1;
                    this._dbg("");
                    // print("Processed", processed_count, "packets")
                    this._dbg("");
                }
                this._dbg("");
                this._dbg(" ** DONE! **");
            }

            public virtual object _wait_for_packet_type(object channel_number, object report_id = null, object timeout = 5.0)
            {
                object report_id_str;
                if (report_id)
                {
                    report_id_str = String.Format(" with report id %s", hex(report_id));
                }
                else
                {
                    report_id_str = "";
                }
                this._dbg("** Waiting for packet on channel", channel_number, report_id_str);
                var start_time = time.monotonic();
                while (_elapsed(start_time) < timeout)
                {
                    var new_packet = this._wait_for_packet();
                    if (new_packet.channel_number == channel_number)
                    {
                        if (report_id)
                        {
                            if (new_packet.report_id == report_id)
                            {
                                return new_packet;
                            }
                        }
                        else
                        {
                            return new_packet;
                        }
                    }
                    if (!(BNO_CHANNEL_EXE, BNO_CHANNEL_SHTP_COMMAND).Contains(new_packet.channel_number))
                    {
                        this._dbg("passing packet to handler for de-slicing");
                        this._handle_packet(new_packet);
                    }
                }
                throw RuntimeError("Timed out waiting for a packet on channel", channel_number);
            }

            public virtual object _wait_for_packet(object timeout = _PACKET_READ_TIMEOUT)
            {
                var start_time = time.monotonic();
                while (_elapsed(start_time) < timeout)
                {
                    if (!this._data_ready)
                    {
                        continue;
                    }
                    var new_packet = this._read_packet();
                    return new_packet;
                }
                throw RuntimeError("Timed out waiting for a packet");
            }

            // update the cached sequence number so we know what to increment from
            // TODO: this is wrong there should be one per channel per direction
            // and apparently per report as well
            public virtual object _update_sequence_number(object new_packet)
            {
                var channel = new_packet.channel_number;
                var seq = new_packet.header.sequence_number;
                this._sequence_number[channel] = seq;
            }

            public virtual object _handle_packet(object packet)
            {
                // split out reports first
                try
                {
                    _separate_batch(packet, this._packet_slices);
                    while (this._packet_slices.Count > 0)
                    {
                        this._process_report(this._packet_slices.pop());
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine(packet);
                    throw error;
                }
            }

            public virtual object _handle_control_report(object report_id, object report_bytes)
            {
                if (report_id == _SHTP_REPORT_PRODUCT_ID_RESPONSE)
                {
                    (sw_part_number, sw_major, sw_minor, sw_patch, sw_build_number) = parse_sensor_id(report_bytes);
                    this._dbg("FROM PACKET SLICE:");
                    this._dbg(String.Format("*** Part Number: %d", sw_part_number));
                    this._dbg(String.Format("*** Software Version: %d.%d.%d", sw_major, sw_minor, sw_patch));
                    this._dbg(String.Format("\tBuild: %d", sw_build_number));
                    this._dbg("");
                }
                if (report_id == _GET_FEATURE_RESPONSE)
                {
                    var get_feature_report = _parse_get_feature_response_report(report_bytes);
                    var _it_1 = get_feature_report;
                    var _report_id = _it_1.Element(0);
                    var feature_report_id = _it_1.Element(1);
                    var _remainder = _it_1.Skip(2).ToList();
                    this._readings[feature_report_id] = _INITIAL_REPORTS.get(feature_report_id, (0.0, 0.0, 0.0));
                }
                if (report_id == _COMMAND_RESPONSE)
                {
                    this._handle_command_response(report_bytes);
                }
            }

            public virtual object _handle_command_response(object report_bytes)
            {
                (report_body, response_values) = _parse_command_response(report_bytes);
                (_report_id, _seq_number, command, _command_seq_number, _response_seq_number) = report_body;
                // status, accel_en, gyro_en, mag_en, planar_en, table_en, *_reserved) = response_values
                var _it_1 = response_values;
                var command_status = _it_1.Element(0);
                var _rest = _it_1.Skip(1).ToList();
                if (command == _ME_CALIBRATE && command_status == 0)
                {
                    this._me_calibration_started_at = time.monotonic();
                }
                if (command == _SAVE_DCD)
                {
                    if (command_status == 0)
                    {
                        this._dcd_saved_at = time.monotonic();
                    }
                    else
                    {
                        throw RuntimeError("Unable to save calibration data");
                    }
                }
            }

            public virtual object _process_report(object report_id, object report_bytes)
            {
                if (report_id >= 0xF0)
                {
                    this._handle_control_report(report_id, report_bytes);
                    return;
                }
                this._dbg("\tProcessing report:", reports[report_id]);
                if (this._debug)
                {
                    var outstr = "";
                    foreach (var _tup_1 in report_bytes.Select((_p_1, _p_2) => Tuple.Create(_p_2, _p_1)))
                    {
                        var idx = _tup_1.Item1;
                        var packet_byte = _tup_1.Item2;
                        var packet_index = idx;
                        if (packet_index % 4 == 0)
                        {
                            outstr += "\nDBG::\t\t[0x{:02X}] ".format(packet_index);
                        }
                        outstr += "0x{:02X} ".format(packet_byte);
                    }
                    this._dbg(outstr);
                    this._dbg("");
                }
                if (report_id == BNO_REPORT_STEP_COUNTER)
                {
                    this._readings[report_id] = _parse_step_couter_report(report_bytes);
                    return;
                }
                if (report_id == BNO_REPORT_SHAKE_DETECTOR)
                {
                    var shake_detected = _parse_shake_report(report_bytes);
                    // shake not previously detected - auto cleared by 'shake' property
                    try
                    {
                        if (!this._readings[BNO_REPORT_SHAKE_DETECTOR])
                        {
                            this._readings[BNO_REPORT_SHAKE_DETECTOR] = shake_detected;
                        }
                    }
                    catch (KeyError)
                    {
                    }
                    return;
                }
                if (report_id == BNO_REPORT_STABILITY_CLASSIFIER)
                {
                    var stability_classification = _parse_stability_classifier_report(report_bytes);
                    this._readings[BNO_REPORT_STABILITY_CLASSIFIER] = stability_classification;
                    return;
                }
                if (report_id == BNO_REPORT_ACTIVITY_CLASSIFIER)
                {
                    var activity_classification = _parse_activity_classifier_report(report_bytes);
                    this._readings[BNO_REPORT_ACTIVITY_CLASSIFIER] = activity_classification;
                    return;
                }
                var _tup_2 = _parse_sensor_report_data(report_bytes);
                var sensor_data = _tup_2.Item1;
                var accuracy = _tup_2.Item2;
                if (report_id == BNO_REPORT_MAGNETOMETER)
                {
                    this._magnetometer_accuracy = accuracy;
                }
                // TODO: FIXME; Sensor reports are batched in a LIFO which means that multiple reports
                // for the same type will end with the oldest/last being kept and the other
                // newer reports thrown away
                this._readings[report_id] = sensor_data;
            }

            // TODO: Make this a Packet creation
            [staticmethod]
            public static object _get_feature_enable_report(object feature_id, object report_interval = _DEFAULT_REPORT_INTERVAL, object sensor_specific_config = 0)
            {
                var set_feature_report = bytearray(17);
                set_feature_report[0] = _SET_FEATURE_COMMAND;
                set_feature_report[1] = feature_id;
                pack_into("<I", set_feature_report, 5, report_interval);
                pack_into("<I", set_feature_report, 13, sensor_specific_config);
                return set_feature_report;
            }

            // TODO: add docs for available features
            // TODO2: I think this should call an fn that imports all the bits for the given feature
            // so we're not carrying around  stuff for extra features
            // Used to enable a given feature of the BNO08x
            public virtual object enable_feature(object feature_id)
            {
                object set_feature_report;
                this._dbg("\n********** Enabling feature id:", feature_id, "**********");
                if (feature_id == BNO_REPORT_ACTIVITY_CLASSIFIER)
                {
                    set_feature_report = this._get_feature_enable_report(feature_id, sensor_specific_config: _ENABLED_ACTIVITIES);
                }
                else
                {
                    set_feature_report = this._get_feature_enable_report(feature_id);
                }
                var feature_dependency = _RAW_REPORTS.get(feature_id, null);
                // if the feature was enabled it will have a key in the readings dict
                if (feature_dependency && !this._readings.Contains(feature_dependency))
                {
                    this._dbg("Enabling feature depencency:", feature_dependency);
                    this.enable_feature(feature_dependency);
                }
                this._dbg("Enabling", feature_id);
                this._send_packet(_BNO_CHANNEL_CONTROL, set_feature_report);
                var start_time = time.monotonic();
                while (_elapsed(start_time) < _FEATURE_ENABLE_TIMEOUT)
                {
                    this._process_available_packets(max_packets: 10);
                    if (this._readings.Contains(feature_id))
                    {
                        return;
                    }
                }
                throw RuntimeError("Was not able to enable feature", feature_id);
            }

            public virtual object _check_id()
            {
                this._dbg("\n********** READ ID **********");
                if (this._id_read)
                {
                    return true;
                }
                var data = bytearray(2);
                data[0] = _SHTP_REPORT_PRODUCT_ID_REQUEST;
                data[1] = 0;
                this._dbg("\n** Sending ID Request Report **");
                this._send_packet(_BNO_CHANNEL_CONTROL, data);
                this._dbg("\n** Waiting for packet **");
                // _a_ packet arrived, but which one?
                while (true)
                {
                    this._wait_for_packet_type(_BNO_CHANNEL_CONTROL, _SHTP_REPORT_PRODUCT_ID_RESPONSE);
                    var sensor_id = this._parse_sensor_id();
                    if (sensor_id)
                    {
                        this._id_read = true;
                        return true;
                    }
                    this._dbg("Packet didn't have sensor ID report, trying again");
                }
                return false;
            }

            public virtual object _parse_sensor_id()
            {
                if (!(this._data_buffer[4] == _SHTP_REPORT_PRODUCT_ID_RESPONSE))
                {
                    return null;
                }
                var sw_major = this._get_data(2, "<B");
                var sw_minor = this._get_data(3, "<B");
                var sw_patch = this._get_data(12, "<H");
                var sw_part_number = this._get_data(4, "<I");
                var sw_build_number = this._get_data(8, "<I");
                this._dbg("");
                this._dbg(String.Format("*** Part Number: %d", sw_part_number));
                this._dbg(String.Format("*** Software Version: %d.%d.%d", sw_major, sw_minor, sw_patch));
                this._dbg(String.Format(" Build: %d", sw_build_number));
                this._dbg("");
                // TODO: this is only one of the numbers!
                return sw_part_number;
            }

            public virtual object _dbg(Hashtable kwargs, params object[] args)
            {
                if (this._debug)
                {
                    Console.WriteLine("DBG::\t\t");
                }
            }

            public virtual object _get_data(object index, object fmt_string)
            {
                // index arg is not including header, so add 4 into data buffer
                var data_index = index + 4;
                return unpack_from(fmt_string, this._data_buffer, offset: data_index)[0];
            }

            public object _data_ready
            {
                get
                {
                    throw RuntimeError("Not implemented");
                }
            }

            // pylint:disable=no-self-use
            // Hardware reset the sensor to an initial unconfigured state
            public virtual object hard_reset()
            {
                if (!this._reset)
                {
                    return;
                }
                this._reset.direction = digitalio.Direction.OUTPUT;
                this._reset.value = true;
                time.sleep(0.01);
                this._reset.value = false;
                time.sleep(0.01);
                this._reset.value = true;
                time.sleep(0.01);
            }

            // Reset the sensor to an initial unconfigured state
            public virtual object soft_reset()
            {
                this._dbg("Soft resetting...", end: "");
                var data = bytearray(1);
                data[0] = 1;
                var _seq = this._send_packet(BNO_CHANNEL_EXE, data);
                time.sleep(0.5);
                _seq = this._send_packet(BNO_CHANNEL_EXE, data);
                time.sleep(0.5);
                foreach (var _i in Enumerable.Range(0, 3))
                {
                    try
                    {
                        var _packet = this._read_packet();
                    }
                    catch (PacketError)
                    {
                        time.sleep(0.5);
                    }
                }
                this._dbg("OK!");
                // all is good!
            }

            public virtual object _send_packet(object channel, object data)
            {
                throw RuntimeError("Not implemented");
            }

            public virtual object _read_packet()
            {
                throw RuntimeError("Not implemented");
            }

            public virtual object _increment_report_seq(object report_id)
            {
                var current = this._two_ended_sequence_numbers.get(report_id, 0);
                this._two_ended_sequence_numbers[report_id] = (current + 1) % 256;
            }

            public virtual object _get_report_seq_id(object report_id)
            {
                return this._two_ended_sequence_numbers.get(report_id, 0);
            }
        }
    }
}
