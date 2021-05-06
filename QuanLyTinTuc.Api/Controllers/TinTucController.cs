
using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using QuanLyTinTuc.Core.Models;
using QuanLyTinTuc.Services;

namespace QuanLyTinTuc.Api.Controllers
{
    [Route("api/[controller]")]
    public class TinTucController:ControllerBase
    {
        private readonly ITinTucServices _tintucServies;
        [HttpGet]
        public List<TinTuc> Get(){
            Console.WriteLine("===============================================");
            return _tintucServies.GetTinTucs();
        }
        [HttpGet("{tintucId}")]
        public TinTuc Get(int tintucId){
            return _tintucServies.GetTinTuc(tintucId);
        }
        [HttpPut("{tintucId}")]
        public TinTuc Put(int tintucId,TinTuc tintuc){
            return _tintucServies.EditTinTuc(tintucId,tintuc);
        }
        [HttpPost]
        public TinTuc Post(TinTuc tintuc){
            return _tintucServies.AddTinTuc(tintuc);
        }
        [HttpDelete("{tintucId}")]
        public void Delete(int tintucId){
            _tintucServies.DeleteTinTuc(tintucId);
        }
    }
}
