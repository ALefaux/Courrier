// <copyright file="AcknowledgmentTest.cs">Copyright ©  2015</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using pqtcourrier;

namespace pqtcourrier.Tests
{
    /// <summary>Cette classe contient des tests unitaires paramétrables pour Acknowledgment</summary>
    [PexClass(typeof(Acknowledgment))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class AcknowledgmentTest
    {
        /// <summary>Stub de test pour .ctor(Sender, Receiver, String)</summary>
        [PexMethod]
        public Acknowledgment ConstructorTest(
            Sender prmSender,
            Receiver prmReceiver,
            string prmContent
        )
        {
            Acknowledgment target = new Acknowledgment(prmSender, prmReceiver, prmContent);
            return target;
            // TODO: ajouter des assertions à méthode AcknowledgmentTest.ConstructorTest(Sender, Receiver, String)
        }

        /// <summary>Stub de test pour executeContent()</summary>
        [PexMethod]
        public void executeContentTest([PexAssumeUnderTest]Acknowledgment target)
        {
            target.executeContent();
            // TODO: ajouter des assertions à méthode AcknowledgmentTest.executeContentTest(Acknowledgment)
        }

        /// <summary>Stub de test pour getDescription()</summary>
        [PexMethod]
        public string getDescriptionTest([PexAssumeUnderTest]Acknowledgment target)
        {
            string result = target.getDescription();
            return result;
            // TODO: ajouter des assertions à méthode AcknowledgmentTest.getDescriptionTest(Acknowledgment)
        }

        /// <summary>Stub de test pour getPrice()</summary>
        [PexMethod]
        public int getPriceTest([PexAssumeUnderTest]Acknowledgment target)
        {
            int result = target.getPrice();
            return result;
            // TODO: ajouter des assertions à méthode AcknowledgmentTest.getPriceTest(Acknowledgment)
        }

        /// <summary>Stub de test pour putContent()</summary>
        [PexMethod]
        public string putContentTest([PexAssumeUnderTest]Acknowledgment target)
        {
            string result = target.putContent();
            return result;
            // TODO: ajouter des assertions à méthode AcknowledgmentTest.putContentTest(Acknowledgment)
        }
    }
}
