﻿using HotelProjectEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProjectBusinessLayer.Abstract
{
    public interface IRoomService : IGenericService<Room>
    {
        int TRoomCount();
    }
}
