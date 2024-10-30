using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniHotelRepo
{
    public interface IRoomInfoRepo
    {
        List<RoomInformation> GetRoomInformations();
        RoomInformation GetRoomInformationById(int id);
        void AddRoomInformation(RoomInformation roomInformation);
        void UpdateRoomInformation(RoomInformation roomInformation);
        void DeleteRoomInformation(int id);
    }
}
