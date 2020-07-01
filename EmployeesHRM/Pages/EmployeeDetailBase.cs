using Employees.Shared;
using EmployeesHRM.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesHRM.Pages
{
	public class EmployeeDetailBase : ComponentBase
	{
		[Parameter]
		public string EmployeeId { get; set; }
		[Inject]
        public IEmployeeDataService EmployeeDataService { get; set; }
        protected override async Task OnInitializedAsync()
		{
			Employee = await EmployeeDataService.GetEmployeeDetails(int.Parse(EmployeeId));
		}

	

		public Employee Employee { get; set; } = new Employee();
	}
}
