<<<<<<< HEAD
﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
=======
﻿using System.ComponentModel.DataAnnotations;
>>>>>>> 04dd3f060b6961622b916f6434925dd7daa95225

namespace RealStateApiBackend.Models.DataModels
{
    public class SearchHouse
    {
<<<<<<< HEAD
        public int? MinPrice { get; set; }
        public int? MaxPrice { get; set; }
=======
        public int MinPrice { get; set; } = 0;
        public int MaxPrice { get; set; } = int.MaxValue;
>>>>>>> 04dd3f060b6961622b916f6434925dd7daa95225
        public string Street { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public int MinSize { get; set; } = 0;
        public int MaxSize { get; set; } = int.MaxValue;
        public int Rooms { get; set; } = int.MaxValue;
        public int Bathroom { get; set; } = int.MaxValue;
        public int ParkingCapacity { get; set; } = int.MaxValue;
        public Type Type { get; set; } = Type.Rent;
    }
<<<<<<< HEAD
}
=======
}


>>>>>>> 04dd3f060b6961622b916f6434925dd7daa95225
