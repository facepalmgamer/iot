using System.Collections;

namespace Iot.Device.Bno08X
{

    public static partial class Module
    {


        public static string @__version__ = "0.0.0";

        public static string @__repo__ = "new git link"; //TODO

        public static int BNO_CHANNEL_SHTP_COMMAND = 0;
        public static int BNO_CHANNEL_EXE = 1;
        public static int _BNO_CHANNEL_CONTROL = 2;
        public static int _BNO_CHANNEL_INPUT_SENSOR_REPORTS = 3;
        public static int _BNO_CHANNEL_WAKE_INPUT_SENSOR_REPORTS = 4;
        public static int _BNO_CHANNEL_GYRO_ROTATION_VECTOR = 5;

        public static int _GET_FEATURE_REQUEST = 0xFE;
        public static int _SET_FEATURE_COMMAND = 0xFD;
        public static int _GET_FEATURE_RESPONSE = 0xFC;
        public static int _BASE_TIMESTAMP = 0xFB;
        public static int _TIMESTAMP_REBASE = 0xFA;

        public static int _SHTP_REPORT_PRODUCT_ID_RESPONSE = 0xF8;
        public static int _SHTP_REPORT_PRODUCT_ID_REQUEST = 0xF9;
        public static int _FRS_WRITE_REQUEST = 0xF7;
        public static int _FRS_WRITE_DATA = 0xF6;
        public static int _FRS_WRITE_RESPONSE = 0xF5;
        public static int _FRS_READ_REQUEST = 0xF4;
        public static int _FRS_READ_RESPONSE = 0xF3;
        public static int _COMMAND_REQUEST = 0xF2;
        public static int _COMMAND_RESPONSE = 0xF1;

        public static int _SAVE_DCD = 0x6;
        public static int _ME_CALIBRATE = 0x7;
        public static int _ME_CAL_CONFIG = 0x00;
        public static int _ME_GET_CAL = 0x01;

        public static int BNO_REPORT_ACCELEROMETER = 0x01;
        public static int BNO_REPORT_GYROSCOPE = 0x02;
        public static int BNO_REPORT_MAGNETOMETER = 0x03;
        public static int BNO_REPORT_LINEAR_ACCELERATION = 0x04;
        public static int BNO_REPORT_ROTATION_VECTOR = 0x05;
        public static int BNO_REPORT_GAME_ROTATION_VECTOR = 0x08;
        public static int BNO_REPORT_GEOMAGNETIC_ROTATION_VECTOR = 0x09;
        public static int BNO_REPORT_STEP_COUNTER = 0x11;
        public static int BNO_REPORT_RAW_ACCELEROMETER = 0x14;
        public static int BNO_REPORT_RAW_GYROSCOPE = 0x15;
        public static int BNO_REPORT_RAW_MAGNETOMETER = 0x16;
        public static int BNO_REPORT_SHAKE_DETECTOR = 0x19;
        public static int BNO_REPORT_STABILITY_CLASSIFIER = 0x13;
        public static int BNO_REPORT_ACTIVITY_CLASSIFIER = 0x1E;
        public static int BNO_REPORT_GYRO_INTEGRATED_ROTATION_VECTOR = 0x2A;

        public static int _DEFAULT_REPORT_INTERVAL = 50000;

        public static double _QUAT_READ_TIMEOUT = 0.5;
        public const double _PACKET_READ_TIMEOUT = 2.0;
        public static double _FEATURE_ENABLE_TIMEOUT = 2.0;
        public static double _DEFAULT_TIMEOUT = 2.0;
        public static int _BNO08X_CMD_RESET = 0x01;
        public static int _QUAT_Q_POINT = 14;
        public static int _BNO_HEADER_LEN = 4;

        public static double _Q_POINT_14_SCALAR = Math.Pow(2, 14 * -1);
        public static double _Q_POINT_12_SCALAR = Math.Pow(2, 12 * -1);
        public static double _Q_POINT_9_SCALAR = Math.Pow(2, 9 * -1);
        public static double _Q_POINT_8_SCALAR = Math.Pow(2, 8 * -1);
        public static double _Q_POINT_4_SCALAR = Math.Pow(2, 4 * -1);

        public static double _GYRO_SCALAR = _Q_POINT_9_SCALAR;
        public static double _ACCEL_SCALAR = _Q_POINT_8_SCALAR;
        public static double _QUAT_SCALAR = _Q_POINT_14_SCALAR;
        public static double _GEO_QUAT_SCALAR = _Q_POINT_12_SCALAR;
        public static double _MAG_SCALAR = _Q_POINT_4_SCALAR;

        public static Dictionary<int, int> _REPORT_LENGTHS = new Dictionary<int, int>
        {
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
                5
            }
        };

        public static Dictionary<int, int> _RAW_REPORTS = new Dictionary<int, int>
        {
            {
                BNO_REPORT_RAW_ACCELEROMETER,
                BNO_REPORT_ACCELEROMETER},
            {
                BNO_REPORT_RAW_GYROSCOPE,
                BNO_REPORT_GYROSCOPE},
            {
                BNO_REPORT_RAW_MAGNETOMETER,
                BNO_REPORT_MAGNETOMETER
            }
        };

        public static Dictionary<int, (double, int, int)> _AVAIL_SENSOR_REPORTS = new Dictionary<int, (double, int, int)>
        {
            {
                BNO_REPORT_ACCELEROMETER,
                (_Q_POINT_8_SCALAR, 3, 10)
            },
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
                (1, 3, 16)
            }
        };


        public static Dictionary<int, object> _INITIAL_REPORTS = new Dictionary<int, object> {
            {
                BNO_REPORT_ACTIVITY_CLASSIFIER,
                new Dictionary<string, object> {
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

        public static int _ENABLED_ACTIVITIES = 0x1FF;

        public static int DATA_BUFFER_SIZE = 512;

        public enum PacketHeader
        {
            channel_number = 0,
            sequence_number = 1,
            data_length = 2,
            packet_byte_count = 3
        };

        public static string[] REPORT_ACCURACY_STATUS =
        {
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

        //TODO
        public static int _elapsed(object start_time)
        {
            return time.monotonic() - start_time;
        }

        //########### PACKET PARSING ###########################
        // Parses reports with only 16-bit fields
        public static (List<double>, double) _parse_sensor_report_data(int[] report_bytes)
        {
            string format_str;
            int data_offset = 4;
            int report_id = report_bytes[0];
            (double, int, int) _tup_1 = _AVAIL_SENSOR_REPORTS[report_id];
            double scalar = _tup_1.Item1;
            int count = _tup_1.Item2;
            int _report_length = _tup_1.Item3;
            if (_RAW_REPORTS.Values.Contains(report_id))
            {
                // raw reports are unsigned
                format_str = "<H";
            }
            else
            {
                format_str = "<h";
            }
            List<double> results = new List<double>();
            int accuracy = UnpackFrom("<B", report_bytes, 2)[0];
            accuracy |= 0b11;
            foreach (var _offset_idx in Enumerable.Range(0, count))
            {
                int total_offset = data_offset + _offset_idx * 2;
                int raw_data = UnpackFrom(format_str, report_bytes, total_offset)[0];
                double scaled_data = raw_data * scalar;
                results.Add(scaled_data);
            }
            return (results, accuracy);
        }

        public static int _parse_step_couter_report(int[] report_bytes)
        {
            return UnpackFrom("<H", report_bytes, offset: 8)[0];
        }

        public static string _parse_stability_classifier_report(int[] report_bytes)
        {
            int classification_bitfield = UnpackFrom("<B", report_bytes, offset: 4)[0];
            return new List<string> {
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
        public static object _parse_get_feature_response_report(int[] report_bytes)
        {
            return UnpackFrom("<BBBHIII", report_bytes);
        }

        // 0 Report ID = 0x1E
        // 1 Sequence number
        // 2 Status
        // 3 Delay
        // 4 Page Number + EOS
        // 5 Most likely state
        // 6-15 Classification (10 x Page Number) + confidence
        public static Dictionary<string, int> _parse_activity_classifier_report(int[] report_bytes)
        {
            List<string> activities = new List<string> {
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
            int end_and_page_number = UnpackFrom("<B", report_bytes, 4)[0];
            // last_page = (end_and_page_number & 0b10000000) > 0
            int page_number = end_and_page_number & 0x7F;
            int most_likely = UnpackFrom("<B", report_bytes, 5)[0];
            int[] confidences = UnpackFrom("<BBBBBBBBB", report_bytes, offset: 6);
            Dictionary<string, int> classification = new Dictionary<string, int>();

            classification.Add(activities[most_likely], 100000);

            foreach (Tuple<int, int> _tup_1 in confidences.Select((_p_1, _p_2) => Tuple.Create(_p_2, _p_1)))
            {
                int idx = _tup_1.Item1;
                int raw_confidence = _tup_1.Item2;
                int confidence = 10 * page_number + raw_confidence;
                string activity_string = activities[idx];
                classification[activity_string] = confidence;
            }
            return classification;
        }

        public static bool _parse_shake_report(int[] report_bytes)
        {
            int shake_bitfield = UnpackFrom("<H", report_bytes, offset: 4)[0];
            return (shake_bitfield & 0x111) > 0;
        }

        // Parse the fields of a product id report
        public static int[] parse_sensor_id(int[] buffer)
        {
            if (!(buffer[0] == _SHTP_REPORT_PRODUCT_ID_RESPONSE))
            {
                throw AttributeError(String.Format("Wrong report id for sensor id: %s", Convert.ToByte(buffer[0])));
            }
            int sw_major = UnpackFrom("<B", buffer, offset: 2)[0];
            int sw_minor = UnpackFrom("<B", buffer, offset: 3)[0];
            int sw_patch = UnpackFrom("<H", buffer, offset: 12)[0];
            int sw_part_number = UnpackFrom("<I", buffer, offset: 4)[0];
            int sw_build_number = UnpackFrom("<I", buffer, offset: 8)[0];
            int[] x = { sw_part_number, sw_major, sw_minor, sw_patch, sw_build_number };
            return x;
        }

        public static (int[], int[]) _parse_command_response(int[] report_bytes)
        {
            // CMD response report:
            // 0 Report ID = 0xF1
            // 1 Sequence number
            // 2 Command
            // 3 Command sequence number
            // 4 Response sequence number
            // 5 R0-10 A set of response values. The interpretation of these values is specific
            // to the response for each command.
            int[] report_body = UnpackFrom("<BBBBB", report_bytes);
            int[] response_values = UnpackFrom("<BBBBBBBBBBB", report_bytes, offset: 5);
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

        public static int _report_length(int report_id)
        {
            if (report_id < 0xF0)
            {
                // it's a sensor report
                return _AVAIL_SENSOR_REPORTS[report_id].Item2;
            }
            return _REPORT_LENGTHS[report_id];
        }

        public static object _separate_batch(Packet packet, object report_slices)
        {
            // get first report id, loop up its report length
            // read that many bytes, parse them

            int next_byte_index = 0;
            while (next_byte_index < packet.header[2])
            {
                int report_id = packet.data[next_byte_index];
                int required_bytes = _report_length(report_id);
                int unprocessed_byte_count = packet.header[2] - next_byte_index;
                // handle incomplete remainder
                if (unprocessed_byte_count < required_bytes)
                {
                    Console.WriteLine("Unprocessable Batch bytes", unprocessed_byte_count);
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
            return report_slices;
        }

        // A class representing a Hillcrest LaboratorySensor Hub Transport packet
        public class Packet
        {
            public int[] data;
            public int[] header;

            public Packet(int[] packet_bytes)
            {
                header = header_from_buffer(packet_bytes);
                var data_end_index = header[2] + _BNO_HEADER_LEN;
                Array.Copy(packet_bytes, _BNO_HEADER_LEN, data, 0, data_end_index - _BNO_HEADER_LEN);
            }

            public override object ToString()
            {
                int length = header[3];
                string outstr = "\n\t\t********** Packet *************\n";
                outstr += "DBG::\t\t HEADER:\n";
                outstr += String.Format("DBG::\t\t Data Len: %d\n", header[2]);
                outstr += String.Format("DBG::\t\t Channel: %s (%d)\n", channels[channel_number], this.channel_number);
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
            public int report_id
            {
                get
                {
                    return data[0];
                }
            }

            // The packet channel
            public int channel_number
            {
                get
                {
                    return header[0];
                }
            }

            // Creates a `PacketHeader` object from a given buffer
            public static int[] header_from_buffer(int[] packet_bytes)
            {
                int packet_byte_count = UnpackFrom("<H", packet_bytes)[0];
                packet_byte_count |= ~0x8000;
                int channel_number = UnpackFrom("<B", packet_bytes, offset: 2)[0];
                int sequence_number = UnpackFrom("<B", packet_bytes, offset: 3)[0];
                int data_length = Math.Max(0, packet_byte_count - 4);
                int[] header = { channel_number, sequence_number, data_length, packet_byte_count };
                return header;
            }

            // Returns True if the header is an error condition
            public static object is_error(int[] header)
            {
                if (header[0] > 5)
                {
                    return true;
                }
                if (header[3] == 0xFFFF && header[1] == 0xFF)
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
            bool _debug;
            object _reset;
            int[] _data_buffer;
            object _command_buffer;
            object _packet_slices;

            List<int> _sequence_number;
            Dictionary<string, Dictionary<object, object>> _two_ended_sequence_numbers;

            int _dcd_saved_at;
            int _me_calibration_started_at;
            bool _calibration_complete;
            int _magnetometer_accuracy;
            bool _wait_for_initialize;
            bool _init_complete;
            bool _id_read;

            Dictionary<int, bool> _readings;

            public BNO08X(object reset = null, bool debug = false)
            {
                _debug = debug;
                _reset = reset;
                _dbg("********** __init__ *************");
                _data_buffer = bytearray(DATA_BUFFER_SIZE);
                _command_buffer = bytearray(12);
                _packet_slices = new List<object>();
                // TODO: this is wrong there should be one per channel per direction
                _sequence_number = new List<int>
                {
                    0,
                    0,
                    0,
                    0,
                    0,
                    0
                };
                _two_ended_sequence_numbers = new Dictionary<string, Dictionary<object, object>>
                {
                    {
                        "send",
                        new Dictionary<object, object> ()
                    },
                    {
                        "receive",
                        new Dictionary<object, object>()
                    }
                };
                _dcd_saved_at = -1;
                _me_calibration_started_at = -1;
                _calibration_complete = false;
                _magnetometer_accuracy = 0;
                _wait_for_initialize = true;
                _init_complete = false;
                _id_read = false;
                // for saving the most recent reading when decoding several packets
                _readings = new Dictionary<int, bool>();
                initialize();
            }

            // Initialize the sensor
            public virtual void initialize()
            {
                foreach (var _ in Enumerable.Range(0, 3))
                {
                    hard_reset();
                    soft_reset();
                    try
                    {
                        if (_check_id())
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
                    catch (Exception)
                    {
                        Console.WriteLine("No magfield report found, is it enabled?");
                        throw;
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
                    catch (Exception)
                    {
                        Console.WriteLine("No quaternion report found, is it enabled?");
                        throw;
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
                    catch (Exception)
                    {
                        Console.WriteLine("No geomag quaternion report found, is it enabled?");
                        throw;
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
                    catch (Exception)
                    {
                        Console.WriteLine("No game quaternion report found, is it enabled?");
                        throw;
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
                    catch (Exception)
                    {
                        Console.WriteLine("No steps report found, is it enabled?");
                        throw;
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
                    catch (Exception)
                    {
                        Console.WriteLine("No lin. accel report found, is it enabled?");
                        throw;
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
                    catch (Exception)
                    {
                        Console.WriteLine("No accel report found, is it enabled?");
                        throw;
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
                    catch (Exception)
                    {
                        Console.WriteLine("No gyro report found, is it enabled?");
                        throw;
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
                    _process_available_packets();
                    try
                    {
                        bool shake_detected = _readings[BNO_REPORT_SHAKE_DETECTOR];
                        // clear on read
                        if (shake_detected)
                        {
                            _readings[BNO_REPORT_SHAKE_DETECTOR] = false;
                        }
                        return shake_detected;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("No shake report found, is it enabled?");
                        throw;
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
                    _process_available_packets();
                    try
                    {
                        var stability_classification = this._readings[BNO_REPORT_STABILITY_CLASSIFIER];
                        return stability_classification;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("No stability classification report found, is it enabled?");
                        throw;
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
                    _process_available_packets();
                    try
                    {
                        var activity_classification = this._readings[BNO_REPORT_ACTIVITY_CLASSIFIER];
                        return activity_classification;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("No activity classification report found, is it enabled?");
                        throw;
                    }
                }
            }

            // Returns the sensor's raw, unscaled value from the accelerometer registers
            public object raw_acceleration
            {
                get
                {
                    _process_available_packets();
                    try
                    {
                        var raw_acceleration = this._readings[BNO_REPORT_RAW_ACCELEROMETER];
                        return raw_acceleration;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("No raw acceleration report found, is it enabled?");
                        throw;
                    }
                }
            }

            // Returns the sensor's raw, unscaled value from the gyro registers
            public object raw_gyro
            {
                get
                {
                    _process_available_packets();
                    try
                    {
                        var raw_gyro = this._readings[BNO_REPORT_RAW_GYROSCOPE];
                        return raw_gyro;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("No raw gyro report found, is it enabled?");
                        throw;
                    }
                }
            }

            // Returns the sensor's raw, unscaled value from the magnetometer registers
            public object raw_magnetic
            {
                get
                {
                    _process_available_packets();
                    try
                    {
                        var raw_magnetic = this._readings[BNO_REPORT_RAW_MAGNETOMETER];
                        return raw_magnetic;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("No raw magnetic report found, is it enabled?");
                        throw;
                    }
                }
            }

            // Begin the sensor's self-calibration routine
            public virtual void begin_calibration()
            {
                // start calibration for accel, gyro, and mag
                _send_me_command(new List<int> {
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
                _calibration_complete = false;
            }

            // Get the status of the self-calibration
            public object calibration_status
            {
                get
                {
                    this._send_me_command(new List<int> {
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

            public virtual object _send_me_command(List<int> subcommand_params)
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
                Console.WriteLine("Could not save calibration data");
            }

            //############## private/helper methods ###############
            // # decorator?
            public virtual object _process_available_packets(int max_packets = null)
            {
                int processed_count = 0;
                while (_data_ready())
                {
                    if (max_packets != null && processed_count > max_packets)
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
                Console.WriteLine("Timed out waiting for a packet on channel", channel_number);
            }

            public virtual object _wait_for_packet(double timeout = _PACKET_READ_TIMEOUT)
            {
                var start_time = time.monotonic();
                while (_elapsed(start_time) < timeout)
                {
                    if (_data_ready())
                    {
                        continue;
                    }
                    Packet new_packet = _read_packet();
                    return new_packet;
                }
                Console.WriteLine("Timed out waiting for a packet");

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

            public virtual object _handle_packet(Packet packet)
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
                    throw;
                }
            }

            public virtual object _handle_control_report(int report_id, object report_bytes)
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
                        Console.WriteLine("Unable to save calibration data");
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
                    catch (Exception)
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
                List<double> sensor_data = _tup_2.Item1;
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
                Console.WriteLine("Was not able to enable feature", feature_id);
            }

            public virtual bool _check_id()
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

            public virtual object _get_data(int index, string fmt_string)
            {
                // index arg is not including header, so add 4 into data buffer
                int data_index = index + 4;
                return UnpackFrom(fmt_string, this._data_buffer, offset: data_index)[0];
            }

            public bool _data_ready()
            {

                Console.WriteLine("Not implemented");

                return true;

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
                        Packet _packet = _read_packet();
                    }
                    catch (PacketError)
                    {
                        time.sleep(0.5);
                    }
                }
                this._dbg("OK!");
                // all is good!
            }

            public virtual void _send_packet(object channel, object data)
            {
                Console.WriteLine("Not implemented");
            }

            public virtual Packet _read_packet()
            {
                Console.WriteLine("Not implemented");
                return null;
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
        public static int[] UnpackFrom(string format, int[] ints, int offset = 0)
        {
            return new int[0];
        }

    }
}
