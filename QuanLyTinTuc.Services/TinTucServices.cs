using System.Collections.Generic;
using System.Linq;
using QuanLyTinTuc.Core;
using QuanLyTinTuc.Core.Models;

namespace QuanLyTinTuc.Services
{
    public class TinTucServices : ITinTucServices
    {
        private readonly DataContext _context;
        public TinTucServices(DataContext context){
            _context = context;
        }
        public TinTuc AddTinTuc(TinTuc tintuc)
        {
            _context.TinTucs.Add(tintuc);
            _context.SaveChanges();
            return tintuc;
        }

        public void DeleteTinTuc(int tintucId)
        {
            var tintuc = _context.TinTucs.FirstOrDefault(x=>x.Id==tintucId);
            if(tintuc == null){
                return;
            }
            _context.TinTucs.Remove(tintuc);
            _context.SaveChanges();
        }

        public TinTuc EditTinTuc(int tintucId, TinTuc tintuc)
        {
            var tintucEdit = _context.TinTucs.FirstOrDefault(x=>x.Id==tintuc.Id);
            if(tintuc == null){
                return null;
            }
            tintucEdit.CategoryId = tintucEdit.CategoryId ;
            tintucEdit.Name = tintucEdit.Name;
            tintucEdit.Description = tintucEdit.Description;
            tintucEdit.ImageUrl = tintucEdit.ImageUrl;
            _context.SaveChanges();
            return tintucEdit;
        }

        public TinTuc GetTinTuc(int tintucId)
        {
            var tintuc = _context.TinTucs.FirstOrDefault(x=>x.Id==tintucId);
            if(tintuc == null){
                return null;
            }
            return tintuc;
        }

        public List<TinTuc> GetTinTucs()
        {
           return _context.TinTucs.ToList();
        }
    }
}