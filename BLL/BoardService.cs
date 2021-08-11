using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BoardService
    {
        public static List<BoardModel> GetAllBoards()
        {
            var data = BoardRepo.GetAllBoards();
            var result = AutoMapper.Mapper.Map<List<Board>, List<BoardModel>>(data);
            return result;
        }

        public static BoardModel GetBoard(int id)
        {
            var data = BoardRepo.GetBoard(id);
            var result = AutoMapper.Mapper.Map<Board, BoardModel>(data);
            return result;
        }

        public static void CreateBoard(BoardModel b)
        {
            var data = AutoMapper.Mapper.Map<BoardModel, Board>(b);
            BoardRepo.CreateBoard(data);
        }

        public static void DeleteBoard(int id)
        {
            BoardRepo.DeleteBoard(id);
        }
    }
}
