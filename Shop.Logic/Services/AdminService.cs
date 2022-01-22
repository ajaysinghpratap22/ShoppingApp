using Shop.DataModel.CustomModels;
using Shop.DataModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Logic.Services
{
    public class AdminService : IAdminService
    {
        private readonly ShoppingCartDBContext _dbContext=null;
        public AdminService(ShoppingCartDBContext appDbContext )
        {
            this._dbContext = appDbContext;
        }
        public ResponseModel AdminLogin(LoginModel loginModel)
        {
            ResponseModel response = new ResponseModel();
            try
            {
                var userData= _dbContext.AdminInfos.Where(x => x.Email == loginModel.EmailId).FirstOrDefault();
                if(userData!=null)
                {
                    if(userData.Password==loginModel.Password)
                    {

                        response.Status = true;
                        response.Message = Convert.ToString(userData.Id) + "|" + userData.Name + "|" + userData.Email;

                    }
                    else
                    {
                        response.Status = false;
                    }
                }
                return response;
            }
            catch(Exception ex)
            {
                response.Status = false;
                response.Message = "An Error has occured. Please try again !";
                return response;
            }
        }
    }
}
