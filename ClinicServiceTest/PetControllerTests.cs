
using ClinicService.Controllers;
using ClinicService.Models;
using ClinicService.Models.Requests;
using ClinicService.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication10.Controllers;
using WebApplication10.Models.Requests;

namespace ClinicServiceTest
{
    public class PetControllerTests
    {
        private PetController _petController;
        private Mock<IPetRepository> _mocPetRepository;

        public PetControllerTests()
        {
            _mocPetRepository = new Mock<IPetRepository>();
            _petController = new PetController(_mocPetRepository.Object);
        }
        [Fact]
        public void GetAllPetsTest()
        {
            List<Pet> list = new List<Pet>();
            list.Add(new Pet());
            list.Add(new Pet());
            list.Add(new Pet());

            _mocPetRepository.Setup(repository =>
            repository.GetAll()).Returns(list);

            ActionResult<List<Pet>> operationResult = _petController.GetAll();
          
           Assert.IsType<OkObjectResult>(operationResult.Result);
            Assert.IsAssignableFrom<List<Pet>>(((OkObjectResult)operationResult.Result).Value);

            _mocPetRepository.Verify(repository =>
                repository.GetAll(), Times.AtLeastOnce());

        }
        public static readonly object[][] CorrectCreatePetData =
        {
            new object[] { new DateTime(2005, 5, 20),  "Bobik", 1 },
            new object[] { new DateTime(2015, 2, 18), "Sharik", 2 },
            new object[] { new DateTime(2020, 1, 22),  "Zhuzha", 3 },
        };

        [Theory]
        [MemberData(nameof(CorrectCreatePetData))]
        public void CreatePetTest(DateTime birthday, string name, int clientId)
        {
            _mocPetRepository.Setup(repository =>
            repository
                .Create(It.IsNotNull<Pet>()))
            .Returns(1).Verifiable();

            ActionResult<int> operationResult =  _petController.Create(new CreatePetRequest
            {
                Birthday = birthday,
                Name = name,
                ClientId = clientId
            });

            Assert.IsType<OkObjectResult>(operationResult.Result);
            Assert.IsAssignableFrom<int>(((OkObjectResult)operationResult.Result).Value);
            _mocPetRepository.Verify(repository =>
            repository.Create(It.IsNotNull<Pet>()), Times.AtLeastOnce());

        }

    }

}
