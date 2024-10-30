using BusinessObject.Models;
using MiniHotelDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniHotelRepo
{
    public class RoomInfoRepo : IRoomInfoRepo
    {
        public void DeleteRoomInformation(int id) => RoomInfoDAO.Instance.DeleteRoom(id);

        public RoomInformation GetRoomInformationById(int id) => RoomInfoDAO.Instance.GetRoomInformationById(id);

        public List<RoomInformation> GetRoomInformations() => RoomInfoDAO.Instance.GetRoomInformations();

        public void AddRoomInformation(RoomInformation roomInformation) => RoomInfoDAO.Instance.AddRoom(roomInformation);

        public void UpdateRoomInformation(RoomInformation roomInformation) => RoomInfoDAO.Instance.UpdateRoomInfo(roomInformation);
    }
}
