using AutoMoqCore;
using CaseItauJogoDaVelha.Application.Helper;
using CaseItauJogoDaVelha.Application.Request;
using CaseItauJogoDaVelha.Controllers;
using CaseItauJogoDaVelha.Service;
using Microsoft.Extensions.Logging;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace CaseItauJogoDaVelhaTests
{
    public class GameTest
    {
        private Mock<ILogger<GameController>> _logger;
        private GameService _service;
        public GameTest()
        {
            _logger = new Mock<ILogger<GameController>>();

            var mocker = new AutoMoqer();
            mocker.Create<GameService>();

            _service = mocker.Resolve<GameService>();
        }


        #region GameController_Post_ReturnWithSuccess_Row_0_Winner_O

        [Fact(DisplayName = "GameController_Post_ReturnWithSuccess_Row_0_Winner_O")]
        public async Task GameController_Post_ReturnWithSuccess_Row_0_Winner_O()
        {
            var controller = new GameController(_logger.Object);

            var result = await controller.Post(GetValues_Row_0_Winner_O(), _service);

            Assert.NotNull(result);
            Assert.True(result.Result);
            Assert.Equal(Constants.messageWinnerO, result.Data);
        }

        private GameRequest GetValues_Row_0_Winner_O()
        {
            var request = new GameRequest();

            var listcolumn = new List<string>
            {
                "o","o","o"
            };

            request.MatrixRequest = new List<List<string>>
            {
                listcolumn
            };

            listcolumn = new List<string>
            {
                "x","x",""
            };

            request.MatrixRequest.Add(listcolumn);

            listcolumn = new List<string>
            {
                "o","",""
            };


            request.MatrixRequest.Add(listcolumn);

            return request;

        }

        #endregion

        #region GameController_Post_ReturnWithSuccess_Row_1_Winner_X

        [Fact(DisplayName = "GameController_Post_ReturnWithSuccess_Row_1_Winner_X")]
        public async Task GameController_Post_ReturnWithSuccess_Row_1_Winner_X()
        {
            var controller = new GameController(_logger.Object);

            var result = await controller.Post(GetValues_Row_1_Winner_X(), _service);

            Assert.NotNull(result);
            Assert.True(result.Result);
            Assert.Equal(Constants.messageWinnerX, result.Data);
        }

        private GameRequest GetValues_Row_1_Winner_X()
        {
            var request = new GameRequest();

            var listcolumn = new List<string>
            {
                "o","o",""
            };

            request.MatrixRequest = new List<List<string>>
            {
                listcolumn
            };

            listcolumn = new List<string>
            {
                "x","x","x"
            };

            request.MatrixRequest.Add(listcolumn);

            listcolumn = new List<string>
            {
                "o","",""
            };


            request.MatrixRequest.Add(listcolumn);

            return request;

        }

        #endregion

        #region GameController_Post_ReturnWithSuccess_Row_2_Winner_O

        [Fact(DisplayName = "GameController_Post_ReturnWithSuccess_Row_2_Winner_O")]
        public async Task GameController_Post_ReturnWithSuccess_Row_2_Winner_O()
        {
            var controller = new GameController(_logger.Object);

            var result = await controller.Post(GetValues_Row_2_Winner_O(), _service);

            Assert.NotNull(result);
            Assert.True(result.Result);
            Assert.Equal(Constants.messageWinnerO, result.Data);
        }

        private GameRequest GetValues_Row_2_Winner_O()
        {
            var request = new GameRequest();

            var listcolumn = new List<string>
            {
               "x","x",""
            };

            request.MatrixRequest = new List<List<string>>
            {
                listcolumn
            };

            listcolumn = new List<string>
            {
              "o","",""
            };

            request.MatrixRequest.Add(listcolumn);

            listcolumn = new List<string>
            {
               "o","o","o"
            };


            request.MatrixRequest.Add(listcolumn);

            return request;

        }

        #endregion


        #region GameController_Post_ReturnWithSuccess_Column_0_Winner_O

        [Fact(DisplayName = "GameController_Post_ReturnWithSuccess_Column_0_Winner_O")]
        public async Task GameController_Post_ReturnWithSuccess_Column_0_Winner_O()
        {
            var controller = new GameController(_logger.Object);

            var result = await controller.Post(GetValues_Column_0_Winner_O(), _service);

            Assert.NotNull(result);
            Assert.True(result.Result);
            Assert.Equal(Constants.messageWinnerO, result.Data);
        }

        private GameRequest GetValues_Column_0_Winner_O()
        {
            var request = new GameRequest();

            var listcolumn = new List<string>
            {
                "o","x","o"
            };

            request.MatrixRequest = new List<List<string>>
            {
                listcolumn
            };

            listcolumn = new List<string>
            {
                "o","x",""
            };

            request.MatrixRequest.Add(listcolumn);

            listcolumn = new List<string>
            {
                "o","",""
            };


            request.MatrixRequest.Add(listcolumn);

            return request;

        }

        #endregion

        #region GameController_Post_ReturnWithSuccess_Column_1_Winner_X

        [Fact(DisplayName = "GameController_Post_ReturnWithSuccess_Column_1_Winner_X")]
        public async Task GameController_Post_ReturnWithSuccess_Column_1_Winner_X()
        {
            var controller = new GameController(_logger.Object);

            var result = await controller.Post(GetValues_Column_1_x(), _service);

            Assert.NotNull(result);
            Assert.True(result.Result);
            Assert.Equal(Constants.messageWinnerX, result.Data);
        }

        private GameRequest GetValues_Column_1_x()
        {
            var request = new GameRequest();

            var listcolumn = new List<string>
            {
                "o","x","o"
            };

            request.MatrixRequest = new List<List<string>>
            {
                listcolumn
            };

            listcolumn = new List<string>
            {
                "o","x",""
            };

            request.MatrixRequest.Add(listcolumn);

            listcolumn = new List<string>
            {
                "","x",""
            };


            request.MatrixRequest.Add(listcolumn);

            return request;

        }

        #endregion

        #region GameController_Post_ReturnWithSuccess_Column_2_Winner_X

        [Fact(DisplayName = "GameController_Post_ReturnWithSuccess_Column_2_Winner_X")]
        public async Task GameController_Post_ReturnWithSuccess_Column_2_Winner_X()
        {
            var controller = new GameController(_logger.Object);

            var result = await controller.Post(GetValues_Column_2_x(), _service);

            Assert.NotNull(result);
            Assert.True(result.Result);
            Assert.Equal(Constants.messageWinnerX, result.Data);
        }

        private GameRequest GetValues_Column_2_x()
        {
            var request = new GameRequest();

            var listcolumn = new List<string>
            {
                "o","o","x"
            };

            request.MatrixRequest = new List<List<string>>
            {
                listcolumn
            };

            listcolumn = new List<string>
            {
                "o","","x"
            };

            request.MatrixRequest.Add(listcolumn);

            listcolumn = new List<string>
            {
                "","","x"
            };


            request.MatrixRequest.Add(listcolumn);

            return request;

        }

        #endregion


        #region GameController_Post_ReturnWithSuccess_Diagonal_0_Winner_O

        [Fact(DisplayName = "GameController_Post_ReturnWithSuccess_Diagonal_0_Winner_O")]
        public async Task GameController_Post_ReturnWithSuccess_Diagonal_0_Winner_O()
        {
            var controller = new GameController(_logger.Object);

            var result = await controller.Post(GetValues_Diagonal_0_Winner_O(), _service);

            Assert.NotNull(result);
            Assert.True(result.Result);
            Assert.Equal(Constants.messageWinnerO, result.Data);
        }

        private GameRequest GetValues_Diagonal_0_Winner_O()
        {
            var request = new GameRequest();

            var listcolumn = new List<string>
            {
                "o","o","x"
            };

            request.MatrixRequest = new List<List<string>>
            {
                listcolumn
            };

            listcolumn = new List<string>
            {
                "x","o",""
            };

            request.MatrixRequest.Add(listcolumn);

            listcolumn = new List<string>
            {
                "","","o"
            };


            request.MatrixRequest.Add(listcolumn);

            return request;

        }

        #endregion

        #region GameController_Post_ReturnWithSuccess_Diagonal_2_Winner_X

        [Fact(DisplayName = "GameController_Post_ReturnWithSuccess_Diagonal_2_Winner_X")]
        public async Task GameController_Post_ReturnWithSuccess_Diagonal_2_Winner_X()
        {
            var controller = new GameController(_logger.Object);

            var result = await controller.Post(GetValues_Diagonal_2_Winner_X(), _service);

            Assert.NotNull(result);
            Assert.True(result.Result);
            Assert.Equal(Constants.messageWinnerX, result.Data);
        }

        private GameRequest GetValues_Diagonal_2_Winner_X()
        {
            var request = new GameRequest();

            var listcolumn = new List<string>
            {
                "o","o","x"
            };

            request.MatrixRequest = new List<List<string>>
            {
                listcolumn
            };

            listcolumn = new List<string>
            {
                "x","x",""
            };

            request.MatrixRequest.Add(listcolumn);

            listcolumn = new List<string>
            {
                "x","",""
            };


            request.MatrixRequest.Add(listcolumn);

            return request;

        }

        #endregion


        #region GameController_Post_ReturnWithSuccess_HasNotWinner

        [Fact(DisplayName = "GameController_Post_ReturnWithSuccess_HasNotWinner")]
        public async Task GameController_Post_ReturnWithSuccess_HasNotWinner()
        {
            var controller = new GameController(_logger.Object);

            var result = await controller.Post(GetValues_HasNotWinner(), _service);

            Assert.NotNull(result);
            Assert.True(result.Result);
            Assert.Equal(Constants.messageHasNotWinner, result.Data);
        }

        private GameRequest GetValues_HasNotWinner()
        {
            var request = new GameRequest();

            var listcolumn = new List<string>
            {
                "o","x","o"
            };

            request.MatrixRequest = new List<List<string>>
            {
                listcolumn
            };

            listcolumn = new List<string>
            {
                "x","x","o"
            };

            request.MatrixRequest.Add(listcolumn);

            listcolumn = new List<string>
            {
                "o","o","x"
            };


            request.MatrixRequest.Add(listcolumn);

            return request;

        }

        #endregion


        #region GameController_Post_ReturnInvalid

        [Fact(DisplayName = "GameController_Post_ReturnInvalid")]
        public async Task GameController_Post_ReturnInvalid()
        {
            var controller = new GameController(_logger.Object);

            var result = await controller.Post(GetValues_Invalid(), _service);

            Assert.NotNull(result);
            Assert.False(result.Result);
            Assert.Equal(Constants.errorMessageInvalidMatrix, result.Errors.FirstOrDefault());
        }

        private GameRequest GetValues_Invalid()
        {
            var request = new GameRequest();

            var listcolumn = new List<string>
            {
                "o","x","o"
            };

            request.MatrixRequest = new List<List<string>>
            {
                listcolumn
            };


            return request;

        }

        #endregion


        #region Request para executar via swagger

        /*
            {
              "matrixRequest": [
                       [
                          "x","x","o"
                       ],
                       [
                          "o","x",""
                       ],
                       [
                           "","x",""
                       ]
               ]
            }
        */

        #endregion

    }
}
