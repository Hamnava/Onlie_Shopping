using HamnavaKala.Core.Interfaces;
using HamnavaKala.Core.ViewModels;
using HamnavaKala.DataLayer.Context;
using HamnavaKala.DataLayer.Entities.Address;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamnavaKala.Core.Servieces
{
    public class AddressService : IAddressService
    {
        private readonly HamnavaKalaContext _context;
        public AddressService(HamnavaKalaContext context)
        {
            _context = context;
        }

        public int addcity(city city)
        {
            try
            {
                _context.cities.Add(city);
                _context.SaveChanges();
                return city.cityid;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int AddProvince(Province province)
        {
            try
            {
                _context.Add(province);
                _context.SaveChanges();
                return province.provinceid;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int addusraddress(useraddress useraddress)
        {
            try
            {
                _context.Add(useraddress);
                _context.SaveChanges();
                return useraddress.addresid;
            }
            catch (Exception)
            {

                return 0;
            }

        }

        public bool deleteaddress(useraddress useraddress)
        {
            try
            {
                useraddress.Isdelete = true;
                _context.Update(useraddress);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool deletecity(city city)
        {
            try
            {
                city.isdelete = true;
                _context.Update(city);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteProvince(Province province)
        {
            try
            {
                province.isDelete = true;
                _context.Update(province);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Existcity(city city)
        {
            return _context.cities.Any(c => c.cityid != city.cityid && c.cityname == city.cityname);
        }

        public bool ExistProvince(int provinceid, string provincename)
        {
            return _context.provinces.Any(p => p.provinceid != provinceid && p.provincename == provincename);
        }

        public ShowAddressForUserViewmodel findaddressforuser(int userid)
        {
            var useraddres = (from ua in _context.Useraddresses
                              join p in _context.provinces on ua.provinceid equals p.provinceid
                              join c in _context.cities on p.provinceid equals c.provinceid

                              where (!ua.Isdelete && ua.userid == userid)
                              select new ShowAddressForUserViewmodel
                              {
                                  userid = ua.userid,
                                  addresid = ua.addresid,
                                  cityname = c.cityname,
                                  FullAddress = ua.FullAddress,
                                  Landlinephonenumber = ua.Landlinephonenumber,
                                  phone = ua.phone,
                                  Plaque = ua.Plaque,
                                  postalCode = ua.postalCode,
                                  provincename = p.provincename,
                                  Recipientname = ua.Recipientname,
                                  unit = ua.unit,
                                  provinceid = p.provinceid,
                                  cityid = c.cityid,
                              }).FirstOrDefault();
            return useraddres;
        }

        public city findbuyeidcity(int cityid)
        {
            return _context.cities.Find(cityid);
        }

        public Province Findprovincebuyeid(int provinceid)
        {
            return _context.provinces.Find(provinceid);
        }

        public List<city> showallcity()
        {
            return _context.cities.Where(c => !c.isdelete).ToList();
        }
        public List<city> showallcityForProvince(int provinceid)
        {
            return _context.cities.Where(c => !c.isdelete && c.provinceid == provinceid).ToList();
        }
        public List<Province> showallProvince()
        {
            return _context.provinces.Where(p => !p.isDelete).ToList();
        }

        public bool updateaddress(useraddress useraddress)
        {
            try
            {
                _context.Update(useraddress);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool updatecity(city city)
        {
            try
            {
                _context.Update(city);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateProvince(Province province)
        {
            try
            {
                _context.Update(province);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
