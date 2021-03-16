using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepositoryPattern;
using System;
using System.Collections.Generic;

namespace StreamingContentRepositoryTest
{
    [TestClass]
    public class UnitTest1
    {
        //so we want to The Add method in the repo
        [TestMethod]
        public void AddToDirectory_ShouldGetCorrectBoolean()
        {
            //AAA-> Arrande, Act, Assert

            //Arrance-> overall setup
            StreamingContent content = new StreamingContent();
            StreamingContentRepository repository = new StreamingContentRepository();

            //Act-> Get/run the code to test
            bool addResult = repository.AddContentToDirectory(content);

            //Assert-> Used to get the expected outomce of a test
            Assert.IsTrue(addResult);
        }

        //Testing the Read Method
        [TestMethod]
        public void GetDirectory_ShouldReturnCorrectCollection()
        {
            //AAA Rules Apply...

            //Arrange
            //Creating the content
            StreamingContent content = new StreamingContent();
            //Creating the repo
            StreamingContentRepository repo = new StreamingContentRepository();
            //Adding to the repo(content)
            repo.AddContentToDirectory(content);
            //_______________________________________________________________________________________________

            //Act
            //our plan is to store list of streaming content within a variable
            List<StreamingContent> contents = repo.GetContent();
            //looks through our entire list and returns true if there is content
            bool directoryHasContent = contents.Contains(content);

            //Assert
            Assert.IsTrue(directoryHasContent);
        }

        //we will start with private 'fields'
        private StreamingContentRepository _repo;
        private StreamingContent _content;

        //This is the arrange part
        [TestInitialize]
        public void Arrange()
        {
            _repo = new StreamingContentRepository();
            _content = new StreamingContent("Rubber", "A car tyre comes to life with the power to make people explode"
                                            , MaturityRating.R, Genre.Drama, 5.8d);

            //Now the movie is in our database
            _repo.AddContentToDirectory(_content);
        }

        //retrive content by title
        [TestMethod]
        public void GetByTitle_ShouldReturnCorrectContent()


        {
            //Arrange... Already done above

            //Act
            StreamingContent searchResult = _repo.GetContentByTitle("Rubber");
            StreamingContent theFailure = _repo.GetContentByTitle("Rubber-duck"); // this would fail if plugged into the assert line, because Rubber-duck is not in 
                                                                                  // our directory

            //Assert
            Assert.AreEqual(_content, searchResult);

        }

        //Test the Update Method
        [TestMethod]
        public void UpdateExistingContent_ShouldReturnTrue()
        {
            //Arrange -> Updated version of our movie
            StreamingContent newContent = new StreamingContent("Rubber Part 2", "A car tyre comes to life with the power to make people explode"
                                            , MaturityRating.R, Genre.Drama, 9.8d);

            //Act
            bool updateResult = _repo.UpdateExistingContent("Rubber", newContent);

            //Assert
            Assert.IsTrue(updateResult);
            
        }

        //Test the Delete Method
        [TestMethod]
        public void DeleteExistingContent_ShouldReturnTrue()
        {
            //Arrange
            StreamingContent content = _repo.GetContentByTitle("Rubber");

            //Act -> We are removing the mocie here...
            bool removeResult = _repo.DeleteExistingContent(content);

            //Assert
            Assert.IsTrue(removeResult);
        }
       
    }
}
