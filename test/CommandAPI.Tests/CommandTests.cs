using System;
using Xunit;
using CommandAPI.Models;

namespace CommandAPI.Tests
{
    public class CommandTests: IDisposable
    {
        Command testCommand;

        public CommandTests()
        {
            testCommand = new Command
            {
                HowTo = "Do something awesome",
                Platform = "xUnit",
                CommandLine = "dotnet test"
            };
        }

        public void Dispose()
        {
            testCommand = null;
        }

        [Fact]
        public void CanChangeHowTo()
        {
            // Arrange

            // Act
            testCommand.HowTo = "Changed";

            // Assert
            Assert.Equal("Changed", testCommand.HowTo);
        }

        [Fact]
        public void CanChangePlatform()
        {
            // Arrange
            // Act
            testCommand.Platform = "Changed";

            // Assert
            Assert.Equal("Changed", testCommand.Platform);

        }

        [Fact]
        public void CanChangeCommandLine()
        {
            // Arrange
            // Act
            testCommand.CommandLine = "Changed";

            // Assert
            Assert.Equal("Changed", testCommand.CommandLine);
        }
    }
}
