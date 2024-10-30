using BusinessObject.Models;
using MiniHotelRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniHotelService
{
    public class RoomTypeService : IRoomTypeService
    {
        private readonly IRoomTypeRepo roomTypeRepo;

        public RoomTypeService() 
        {
            roomTypeRepo = new RoomTypeRepo();
        }

        public void AddRoomType(RoomType roomType) => roomTypeRepo.AddRoomType(roomType);

        public void DeleteRoomType(int id) => roomTypeRepo.DeleteRoomType(id);

        public RoomType GetRoomTypeById(int id) => roomTypeRepo.GetRoomTypeById(id);

        public List<RoomType> GetRoomTypes() => roomTypeRepo.GetRoomTypes();

        public void UpdateRoomType(RoomType roomType) => roomTypeRepo.UpdateRoomType(roomType);
    }
}
