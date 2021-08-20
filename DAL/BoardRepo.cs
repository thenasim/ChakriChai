using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BoardRepo
    {
        private static readonly ChakriChaiContext context;

        static BoardRepo()
        {
            context = new ChakriChaiContext();
        }

        public static List<Board> GetAllBoards()
        {
            return context.Boards.ToList();
        }

        public static Board GetBoard(int id)
        {
            return context.Boards.Find(id);
        }

        public static void CreateBoard(Board b)
        {
            context.Boards.Add(b);
            context.SaveChanges();
        }

        public static void UpdateBoard(Board b, int id)
        {
            var board = context.Boards.Find(id);

            b.BoardId = board.BoardId;

            context.Entry(board).CurrentValues.SetValues(b);
            context.SaveChanges();
        }

        public static void DeleteBoard(int id)
        {
            var board = context.Boards.Find(id);
            context.Boards.Remove(board);
            context.SaveChanges();
        }
    }
}
