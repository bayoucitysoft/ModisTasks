
using ModisTasks.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModisTasks.Models
{
    public class SamplesModel
    {

        public int SampleId { get; set; }
        public long Barcode { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int StatusId { get; set; }

        public SamplesModel()
        {

        }

        public SamplesModel(int id, long barcode, DateTime createdAt, int createdBy, int statusId)
        {
            SampleId = id;
            Barcode = barcode;
            CreatedAt = createdAt;
            CreatedBy = createdBy;
            StatusId = statusId;
        }
    }

    public class SamplesModelCollection : IModelCollection
    { 
        public List<SamplesModel> Contents { get; set; }

        public SamplesModelCollection()
        {
            Contents = new List<SamplesModel>();
        }
        /// <summary>
        /// simulates a: select * from Samples
        /// </summary>
        public void Generate()
        {
            
            Contents.Add(new SamplesModel(1, 129076, DateTime.Parse("2015-01-02"), 6, 3));
            Contents.Add(new SamplesModel(2, 850314, DateTime.Parse("2015-06-15"), 7, 3));
            Contents.Add(new SamplesModel(3,176033, DateTime.Parse("2015-07-31"), 7,0));
            Contents.Add(new SamplesModel(4,129629, DateTime.Parse("2015-01-21"), 3,0));
            Contents.Add(new SamplesModel(5,773561, DateTime.Parse("2015-02-21"), 9,1));
            Contents.Add(new SamplesModel(6,255253, DateTime.Parse("2015-05-13"), 9,0));
            Contents.Add(new SamplesModel(7,693294, DateTime.Parse("2015-05-11"), 3,2));
            Contents.Add(new SamplesModel(8,455116, DateTime.Parse("2015-09-13"), 6,0));
            Contents.Add(new SamplesModel(9,280561, DateTime.Parse("2015-04-08"), 5,3));
            Contents.Add(new SamplesModel(10,863760, DateTime.Parse("2016-01-25"), 0,3));
            Contents.Add(new SamplesModel(11,211102, DateTime.Parse("2015-08-24"), 4,2));
            Contents.Add(new SamplesModel(12,193882, DateTime.Parse("2016-01-23"), 8,1));
            Contents.Add(new SamplesModel(13,502533, DateTime.Parse("2016-03-08"), 2,1));
            Contents.Add(new SamplesModel(14,371726, DateTime.Parse("2015-04-15"), 8,1));
            Contents.Add(new SamplesModel(15,807891, DateTime.Parse("2015-05-17"), 2,1));
            Contents.Add(new SamplesModel(16,845318, DateTime.Parse("2016-03-22"), 7,1));
            Contents.Add(new SamplesModel(17,601386, DateTime.Parse("2015-11-18"), 3,1));
            Contents.Add(new SamplesModel(18,978804, DateTime.Parse("2015-05-31"), 5,2));
            Contents.Add(new SamplesModel(19,759456, DateTime.Parse("2015-09-23"), 8,2));
            Contents.Add(new SamplesModel(20,949933, DateTime.Parse("2015-07-04"), 0,3));
            Contents.Add(new SamplesModel(21,411443, DateTime.Parse("2015-03-16"), 3,0));
            Contents.Add(new SamplesModel(22,202485, DateTime.Parse("2015-09-03"), 0,3));
            Contents.Add(new SamplesModel(23,737715, DateTime.Parse("2015-10-07"), 0,1));
            Contents.Add(new SamplesModel(24,106957, DateTime.Parse("2015-10-03"), 7,1));
            Contents.Add(new SamplesModel(25,561154, DateTime.Parse("2016-02-23"), 9,1));
            Contents.Add(new SamplesModel(26,923720, DateTime.Parse("2015-06-09"), 2,1));
            Contents.Add(new SamplesModel(27,985114, DateTime.Parse("2015-04-17"), 4,0));
            Contents.Add(new SamplesModel(28,544078, DateTime.Parse("2015-06-16"), 6,3));
            Contents.Add(new SamplesModel(29,605315, DateTime.Parse("2015-06-23"), 7,0));
            Contents.Add(new SamplesModel(30,588963, DateTime.Parse("2015-02-13"), 7,1));
            Contents.Add(new SamplesModel(31,646434, DateTime.Parse("2015-08-23"), 0,2));
            Contents.Add(new SamplesModel(32,819931, DateTime.Parse("2015-11-10"), 0,2));
            Contents.Add(new SamplesModel(33,978799, DateTime.Parse("2015-11-06"), 2,3));
            Contents.Add(new SamplesModel(34,250878, DateTime.Parse("2016-03-14"), 6,1));
            Contents.Add(new SamplesModel(35,499463, DateTime.Parse("2015-10-20"), 5,3));
            Contents.Add(new SamplesModel(36,261808, DateTime.Parse("2015-09-25"), 5,3));
            Contents.Add(new SamplesModel(37,496077, DateTime.Parse("2015-04-12"), 8,2));
            Contents.Add(new SamplesModel(38,939988, DateTime.Parse("2015-05-15"), 4,2));
            Contents.Add(new SamplesModel(39,142598, DateTime.Parse("2015-06-04"), 7,1));
            Contents.Add(new SamplesModel(40,648235, DateTime.Parse("2015-12-26"), 6,2));
            Contents.Add(new SamplesModel(41,949270, DateTime.Parse("2015-10-22"), 0,0));
            Contents.Add(new SamplesModel(42,606179, DateTime.Parse("2015-10-12"), 5,2));
            Contents.Add(new SamplesModel(43,762654, DateTime.Parse("2016-03-04"), 2,0));
            Contents.Add(new SamplesModel(44,230403, DateTime.Parse("2015-07-20"), 5,1));
            Contents.Add(new SamplesModel(45,419103, DateTime.Parse("2016-02-09"), 2,0));
            Contents.Add(new SamplesModel(46,105914, DateTime.Parse("2016-01-19"), 5,3));
            Contents.Add(new SamplesModel(47,292591, DateTime.Parse("2016-04-04"), 0,2));
            Contents.Add(new SamplesModel(48,460439, DateTime.Parse("2016-03-25"), 2,3));
            Contents.Add(new SamplesModel(49,905492, DateTime.Parse("2015-02-13"), 4,0));
            Contents.Add(new SamplesModel(50,454128, DateTime.Parse("2015-09-20"), 2,1));
            Contents.Add(new SamplesModel(51,245743, DateTime.Parse("2015-04-17"), 2,0));
            Contents.Add(new SamplesModel(52,127239, DateTime.Parse("2015-09-24"), 3,3));
            Contents.Add(new SamplesModel(53,747765, DateTime.Parse("2015-10-16"), 5,0));
            Contents.Add(new SamplesModel(54,141601, DateTime.Parse("2015-03-31"), 2,1));
            Contents.Add(new SamplesModel(55,427192, DateTime.Parse("2015-03-01"), 3,3));
            Contents.Add(new SamplesModel(56,779537, DateTime.Parse("2015-04-25"), 3,0));
            Contents.Add(new SamplesModel(57,614487, DateTime.Parse("2015-12-04"), 8,3));
            Contents.Add(new SamplesModel(58,771285, DateTime.Parse("2015-12-24"), 7,3));
            Contents.Add(new SamplesModel(59,868108, DateTime.Parse("2016-01-21"), 5,3));
            Contents.Add(new SamplesModel(60,586986, DateTime.Parse("2015-11-07"), 1,3));
            Contents.Add(new SamplesModel(61,957210, DateTime.Parse("2015-01-28"), 0,3));
            Contents.Add(new SamplesModel(62,925265, DateTime.Parse("2016-02-09"), 6,2));
            Contents.Add(new SamplesModel(63,229746, DateTime.Parse("2015-08-02"), 1,2));
            Contents.Add(new SamplesModel(64,329580, DateTime.Parse("2015-05-07"), 4,0));
            Contents.Add(new SamplesModel(65,398802, DateTime.Parse("2015-11-18"), 3,1));
            Contents.Add(new SamplesModel(66,793846, DateTime.Parse("2016-04-04"), 7,3));
            Contents.Add(new SamplesModel(67,194543, DateTime.Parse("2015-01-16"), 0,2));
            Contents.Add(new SamplesModel(68,699892, DateTime.Parse("2016-03-06"), 5,2));
            Contents.Add(new SamplesModel(69,849262, DateTime.Parse("2015-11-20"), 5,0));
            Contents.Add(new SamplesModel(70,212969, DateTime.Parse("2016-02-23"), 1,2));
            Contents.Add(new SamplesModel(71,913224, DateTime.Parse("2015-08-17"), 6,3));
            Contents.Add(new SamplesModel(72,283784, DateTime.Parse("2015-01-23"), 1,3));
            Contents.Add(new SamplesModel(73,964445, DateTime.Parse("2015-03-07"), 1,1));
            Contents.Add(new SamplesModel(74,219254, DateTime.Parse("2015-06-11"), 7,2));
            Contents.Add(new SamplesModel(75,136235, DateTime.Parse("2015-03-21"), 4,3));
            Contents.Add(new SamplesModel(76,371430, DateTime.Parse("2015-03-19"), 2,2));
            Contents.Add(new SamplesModel(77,219597, DateTime.Parse("2015-12-12"), 3,3));
            Contents.Add(new SamplesModel(78,721655, DateTime.Parse("2016-04-29"), 5,2));
            Contents.Add(new SamplesModel(79,434154, DateTime.Parse("2016-02-25"), 8,0));
            Contents.Add(new SamplesModel(80,290254, DateTime.Parse("2015-11-02"), 9,2));
            Contents.Add(new SamplesModel(81,736586, DateTime.Parse("2015-05-30"), 4,2));
            Contents.Add(new SamplesModel(82,622526, DateTime.Parse("2015-11-08"), 0,1));
            Contents.Add(new SamplesModel(83,693936, DateTime.Parse("2016-03-21"), 1,0));
            Contents.Add(new SamplesModel(84,529728, DateTime.Parse("2015-02-25"), 1,2));
            Contents.Add(new SamplesModel(85,963244, DateTime.Parse("2015-11-22"), 9,0));
            Contents.Add(new SamplesModel(86,261164, DateTime.Parse("2015-06-26"), 9,2));
            Contents.Add(new SamplesModel(87,986536, DateTime.Parse("2016-01-07"), 6,1));
            Contents.Add(new SamplesModel(88,572741, DateTime.Parse("2015-12-01"), 6,1));
            Contents.Add(new SamplesModel(89,125921, DateTime.Parse("2015-08-03"), 2,2));
            Contents.Add(new SamplesModel(90,262858, DateTime.Parse("2015-12-07"), 3,0));
            Contents.Add(new SamplesModel(91,879489, DateTime.Parse("2015-09-02"), 7,1));
            Contents.Add(new SamplesModel(92,105797, DateTime.Parse("2015-12-26"), 6,1));
            Contents.Add(new SamplesModel(93,806498, DateTime.Parse("2015-07-26"), 8,3));
            Contents.Add(new SamplesModel(94,960686, DateTime.Parse("2016-04-07"), 2,2));
            Contents.Add(new SamplesModel(95,201332, DateTime.Parse("2015-09-19"), 4,0));
            Contents.Add(new SamplesModel(96,405572, DateTime.Parse("2015-11-04"), 3,0));
            Contents.Add(new SamplesModel(97,204617, DateTime.Parse("2015-09-05"), 5,1));
            Contents.Add(new SamplesModel(98,767548, DateTime.Parse("2016-02-09"), 7,2));
            Contents.Add(new SamplesModel(99,363492, DateTime.Parse("2015-12-18"), 6,1));
            Contents.Add(new SamplesModel(100,541884, DateTime.Parse("2015-07-07"), 5,1));
        }
    }

}