using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace ApplicationModelConventionTest {

	public class TestConvention : IApplicationModelConvention {

		public TestConvention() {
		}

		public void Apply(ApplicationModel application) {

			var guid = Guid.NewGuid();

			System.Diagnostics.Debug.WriteLine($"Calling TestConvention.Apply at {DateTime.Now}, before sleep, Id: {guid}");
			System.Threading.Thread.Sleep(5000);
			System.Diagnostics.Debug.WriteLine($"Calling TestConvention.Apply at {DateTime.Now}, after sleep, Id: {guid}");
		}
	}
}
