Please find the Stored procedure used in:

Create Procedure GetEmpData
as
begin
Select e.FirstName,e.LastName,c.CityName,e.JoiningDate,e.salary,s.Designation
From Emp_Masters e 
join City_Masters c on e.CityID=c.CityId
join Salary_Masters s on e.salary between s.StartingAmount and s.EndAmount
end
