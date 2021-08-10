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

        public static void UpdateBoard(Board b, int id)
        {
            // TODO: Verify this method
            var board = context.Boards.Find(id);
            board = b;
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
