using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniHotelDAO
{
    public class RoomInfoDAO
    {
        private FuminiHotelManagementContext dbcontext;
        private static RoomInfoDAO instance;

        public static RoomInfoDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RoomInfoDAO();
                }
                return instance;
            }
        }

        public RoomInfoDAO()
        {
            dbcontext = new FuminiHotelManagementContext();
        }

        public RoomInformation GetRoomInformationById(int id)
        {
            return dbcontext.RoomInformations.SingleOrDefault(n => n.RoomId.Equals(id));
        }

        public List<RoomInformation> GetRoomInformations()
        {
            return dbcontext.RoomInformations.ToList();
        }

        public void AddRoom(RoomInformation room)
        {
            bool isSuccess = false;
            RoomInformation roominfo = GetRoomInformationById(room.RoomId);
            if (roominfo == null)
            {
                dbcontext.RoomInformations.Add(room);
                dbcontext.SaveChanges();
                isSuccess = true;
            }
        }

        public bool UpdateRoomInfo(RoomInformation updateroominfo)
        {
            var room = GetRoomInformationById(updateroominfo.RoomId);
            if (room != null)
            {
                room.RoomNumber = updateroominfo.RoomNumber;
                room.RoomId = updateroominfo.RoomId;
                room.RoomMaxCapacity = updateroominfo.RoomMaxCapacity;
                room.RoomPricePerDay = updateroominfo.RoomPricePerDay;
                room.RoomDetailDescription = updateroominfo.RoomDetailDescription;
                room.RoomStatus = updateroominfo.RoomStatus;
                room.RoomTypeId = updateroominfo.RoomTypeId;
                return true;
            }
            return false;
        }

        public bool DeleteRoom(int roomId)
        {
            var room = GetRoomInformationById(roomId);
            if (room != null)
            {
                dbcontext.Remove(room);
                return true;
            }
            return false;
        }
    }
}
