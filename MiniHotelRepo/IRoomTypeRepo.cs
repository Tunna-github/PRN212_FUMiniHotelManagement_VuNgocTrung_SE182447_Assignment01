using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniHotelRepo
{
    public interface IRoomTypeRepo
    {
        List<RoomType> GetRoomTypes();
        RoomType GetRoomTypeById(int id);
        void AddRoomType(RoomType roomType);
        void UpdateRoomType(RoomType roomType);
        void DeleteRoomType(int id);
    }
}
