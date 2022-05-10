using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParcelShipping.Models;
using System;
using System.Collections.Generic;

namespace ParcelShipping.Tests
{
	[TestClass]
	public class Tests
	{
		[TestMethod]
		public void Parcel_CreateNewInstanceOfClass_NewParcel()
		{
			Parcel newParcel = new Parcel();
			Assert.AreEqual(typeof(Parcel),  newParcel.GetType());
		}
	}
}
