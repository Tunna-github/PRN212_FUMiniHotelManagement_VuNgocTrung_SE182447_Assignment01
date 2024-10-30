using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniHotelDAO
{
    public class RoomTypeDAO
    {
        private static RoomTypeDAO instance = null;
        private FuminiHotelManagementContext dbcontext;

        public static RoomTypeDAO Instance {
            get
            {
                if (instance == null)
                {
                    instance = new RoomTypeDAO();
                }
                return instance;
            }
        }

        public RoomTypeDAO()
        {
            dbcontext = new FuminiHotelManagementContext();
        }

        public List<RoomType> GetRoomType() => dbcontext.RoomTypes.ToList();

        public  RoomType GetRoomTypeById(int id)
        {
            return dbcontext.RoomTypes.Find(id);
        }

        public void AddRoomType(RoomType roomType)
        {
            dbcontext.RoomTypes.Add(roomType);
            dbcontext.SaveChanges();
        }

        public bool UpdateRoomType(RoomType updateroomType)
        {
            var roomType = dbcontext.RoomTypes.Find(updateroomType.RoomTypeId);
            if (roomType != null)
            {
                roomType.RoomTypeName = updateroomType.RoomTypeName;
                roomType.TypeDescription = updateroomType.TypeDescription;
                roomType.TypeNote = updateroomType.TypeNote;

                dbcontext.Entry(roomType).State = EntityState.Modified;
                dbcontext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool DeleteRoomType(int id)
        {
            var roomType = dbcontext.RoomTypes.Find(id);
            if (roomType != null)
            {
                dbcontext.RoomTypes.Remove(roomType);
                dbcontext.SaveChanges();
                return true;
            }
            return false;
        }
    }
    }
