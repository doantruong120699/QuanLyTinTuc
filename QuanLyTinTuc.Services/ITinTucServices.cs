using System.Collections.Generic;
using QuanLyTinTuc.Core.Models;

namespace QuanLyTinTuc.Services
{
    public interface ITinTucServices
    {
        public List<TinTuc> GetTinTucs();
        public TinTuc GetTinTuc (int tintucId);
        public TinTuc AddTinTuc (TinTuc tintuc);
        public TinTuc EditTinTuc (int tintucId,TinTuc tintuc);
        public void DeleteTinTuc(int tintuc);
    }
}