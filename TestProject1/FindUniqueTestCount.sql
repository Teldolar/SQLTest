SELECT project.name,count(Distinct test.name) as test FROM union_reporting.test
Join union_reporting.project on project.id=test.project_id
Group by project_id;