using Microsoft.AspNetCore.Mvc;
using BookStore.Repository;
using Bookstore.Models.Models;
using Bookstore.Models.ViewModels;
using System;
using System.Net;
using BookStore.Models.Models;

namespace BookStoreApi.Controllers
{
    [ApiController]
    [Route("api/BookStore")]
    public class BookStoreController : ControllerBase
    {
        UserRepository _repository = new UserRepository();
        [HttpGet]
        [Route("GetUser")]
        public IActionResult GetUsers()
        {
            return Ok(_repository.GetUsers());
        }

        [HttpPost]
        [Route("LogIn")]
        public IActionResult Login(LoginModel model)
        {
            User user = _repository.Login(model);
            if (user == null)
                return NotFound();

            UserModel userModel = new UserModel(user);

            return Ok(userModel);
        }

        [HttpPost]
        [Route("RegisterUser")]
        public IActionResult Register(RegisterModel model)
        {
            User user = _repository.Register(model);
            if (user == null)
                return BadRequest();

            return Ok(user);
        }
    }
}