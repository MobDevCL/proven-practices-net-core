using mobdev.bestpractice.domain;
using NUnit.Framework;
using System;

namespace mobdev.bestpractice.test
{

    public class Test_FileProcess
    {
        private const string GOOD_FILE = @"D:\temp\GoodFile.txt";
        private const string BAD_FILE = @"D:\temp\BadFile.txt";

        [Test]
        public void FileNameDoesExist()
        {
            //Arrange
            FileProcess fp = new FileProcess();
            bool fromCall;
            //Acto
            fromCall = fp.FileExist(GOOD_FILE);
            //Assert
            Assert.IsTrue(fromCall);
        }

        [Test]
        public void FileNameDoesNotExist()
        {
            //Arrange
            FileProcess fp = new FileProcess();
            bool fromCall;
            //Acto
            fromCall = fp.FileExist(BAD_FILE);
            //Assert
            Assert.IsFalse(fromCall);
        }


        [Test]
        public void FileNameNullOrEmpty_throwsArgumentNullException()
        {
            FileProcess fp = new FileProcess();
            Assert.Throws<ArgumentNullException>(() => fp.FileExist(""));
        }

    }
}