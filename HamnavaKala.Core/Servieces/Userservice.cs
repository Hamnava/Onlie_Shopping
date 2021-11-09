using HamnavaKala.Core.Interfaces;
using HamnavaKala.Core.ViewModels;
using HamnavaKala.DataLayer.Context;
using HamnavaKala.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamnavaKala.Core.Servieces
{
    public class Userservice : IUserservice
    {
        private readonly HamnavaKalaContext _context;
        public Userservice(HamnavaKalaContext context)
        {
            _context = context;
        }
        public bool Deleteuser(User user)
        {
            try
            {
                user.IsDelete = true;
                _context.Users.Update(user);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool ExistEmail(string email, int id)
        {
            return _context.Users.Any(u => u.Email == email && u.UserId != id);
        }

        public User FindUser(int id, string code)
        {
            return _context.Users.Where(u => u.UserId == id && u.ActiceCode == code).FirstOrDefault();
        }

        public User FindUserByEmail(string email)
        {
            return _context.Users.Where(u => u.Email == email).FirstOrDefault();
        }

        public User LoginUser(string email, string password)
        {
            return _context.Users.Where(u => u.Password == password && u.Email == email).SingleOrDefault();
        }

        public int RegisterUser(User user)
        {
            try
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                return user.UserId;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public bool Updateuser(User user)
        {
            try
            {
                _context.Users.Update(user);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public informationAccountViewmodel informationAccount(int userid)
        {
            return _context.Users.Where(x => x.UserId == userid).Select(x => new informationAccountViewmodel
            {

                DateTime = x.CreateDate,
                email = x.Email,
                userid = x.UserId,
                phone = x.Phone,
                userfamily = x.LastName,
                username = x.FirstName,

            }).FirstOrDefault();
        }

        //public edituserViewmodel finduserbuyeid(int userid)
        //{
        //    return _context.users.Where(x => x.userid == userid)
        //        .Select(x => new edituserViewmodel
        //        {
        //            email = x.email,
        //            phone = x.phone,
        //            userfamily = x.userfamily,
        //            username = x.username

        //        }).FirstOrDefault();
        //}
        //public user findEditUserbuyeid(int userid)
        //{
        //    return _context.users.Find(userid);

        //}

        //public List<showfavoirateViewmodel> showfavoirateUser(int userid)
        //{
        //    return (from f in _context.Faviorates
        //            join u in _context.users on f.userid equals u.userid
        //            join p in _context.products on f.productid equals p.productid
        //            where (f.userid == userid)
        //            select new showfavoirateViewmodel
        //            {
        //                productfatitle = p.productFaTitle,
        //                productid = p.productid,
        //                productimage = p.Productimage,
        //                productstar = p.producStart,

        //                productprice = _context.ProductPrices.Where(x => x.count > 0
        //                  && x.productid == p.productid)
        //                .OrderBy(x => x.mainprice).Select(x => x.mainprice).FirstOrDefault(),

        //            }).ToList();

        //}

        //public List<showorderForUser> showorderForUsers(int userid)
        //{
        //    return _context.cart.Where(x => x.userid == userid).Select(x => new showorderForUser
        //    {
        //        cartid = x.cartid,
        //        createdate = x.CreateDate.MilatiToShamsi(),
        //        ispaye = x.ispay,
        //        totalprice = x.TotalPrice,

        //    }).ToList();

        //}


        //public List<mycommentViewmodel> mycomment(int userid)
        //{
        //    return (from c in _context.comments
        //            join p in _context.products on c.productid equals p.productid
        //            where (c.userid == userid)
        //            select new mycommentViewmodel
        //            {
        //                commenttitle = c.commentTitle,
        //                isactive = c.IsActive,
        //                productFaTitle = p.productFaTitle,
        //                productid = p.productid,
        //                productstar = p.producStart,
        //                productimage = p.Productimage,
        //            }).ToList();


        //}

        //public List<ShowDetailorder> showDetailorders(int orderid)
        //{
        //    var b = (from cd in _context.CartDetail
        //             join c in _context.cart on cd.Cartid equals c.cartid
        //             join p in _context.products on cd.productid equals p.productid
        //             where (cd.Cartid == orderid)
        //             select new ShowDetailorder
        //             {
        //                 productid = p.productid,
        //                 cartid = c.cartid,
        //                 price = cd.price,
        //                 productFaTitle = p.productFaTitle,
        //                 Totalprice = c.TotalPrice,

        //             }).ToList();
        //    return b;
        //}

    }
}
