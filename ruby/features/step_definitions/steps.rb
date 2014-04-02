Given(/^the monthly gross salary of the employee is (\d+)$/) do |gross_salary|
	@gross_salary = gross_salary.to_i
end

Given(/^there are no children in the family$/) do
	@child_count = 0
end

Given(/^there are (\d+) children in the family$/) do |child_count|
	@child_count = child_count.to_i
end

When(/^the tax is calculated$/) do
	ssc = @gross_salary * 0.185
	income_tax = @gross_salary * 0.16
	tax_relief = @child_count <= 2 ? @child_count * 10000 : @child_count * 33000
	income_tax = income_tax > tax_relief ? income_tax - tax_relief : 0
	@net_salary = @gross_salary - ssc - income_tax
end

Then(/^the monthly net salary of the employee should be (\d+)$/) do |expacted_net_salary|
	@net_salary.should eq(expacted_net_salary.to_i)
end

Then(/^the following taxes are paid by the employee$/) do |table|
  # table is a Cucumber::Ast::Table
end

