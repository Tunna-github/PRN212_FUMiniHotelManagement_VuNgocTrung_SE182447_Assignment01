using BusinessObject.Models;
using MiniHotelDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniHotelRepo
{
    public class RoomTypeRepo : IRoomTypeRepo
    {
        public void DeleteRoomType(int id) => RoomTypeDAO.Instance.DeleteRoomType(id);

        public RoomType GetRoomTypeById(int id) => RoomTypeDAO.Instance.GetRoomTypeById(id);

        public List<RoomType> GetRoomTypes() => RoomTypeDAO.Instance.GetRoomType();

        public void AddRoomType(RoomType roomType) => RoomTypeDAO.Instance.AddRoomType(roomType);

        public void UpdateRoomType(RoomType roomType) => RoomTypeDAO.Instance.UpdateRoomType(roomType);
    }
}
