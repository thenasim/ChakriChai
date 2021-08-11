using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ChakriChai.Controllers
{
    public class BoardController : ApiController
    {
        [Route("api/Board/GetAll")]
        public List<BoardModel> GetAllBoards() {
            return BoardService.GetAllBoards();
        }


        [Route("api/Board/Get/{id}")]
        public BoardModel Get(int id) {
            return BoardService.GetBoard(id);
        }

        [HttpPost()]
        [Route("api/Board/Create")]
        public void CreateBoard(BoardModel b)
        {
            BoardService.CreateBoard(b);
        }

        [Route("api/Board/Delete/{id}")]
        public void Delete(int id)
        {
            BoardService.DeleteBoard(id);
        }
    }
}
