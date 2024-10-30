using BusinessObject.Models;
using MiniHotelRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniHotelService
{
    public class RoomInfoService : IRoomInfoService
    {
        private readonly IRoomInfoRepo roomInfoRepo;

        public RoomInfoService() 
        {
            roomInfoRepo = new RoomInfoRepo();
        }
        public void AddRoomInformation(RoomInformation roomInformation) => roomInfoRepo.AddRoomInformation(roomInformation);

        public void DeleteRoomInformation(int id) => roomInfoRepo.DeleteRoomInformation(id);

        public RoomInformation GetRoomInformationById(int id) => roomInfoRepo.GetRoomInformationById(id);

        public List<RoomInformation> GetRoomInformations() => roomInfoRepo.GetRoomInformations();

        public void UpdateRoomInformation(RoomInformation roomInformation) => roomInfoRepo.UpdateRoomInformation(roomInformation);
    }
}
