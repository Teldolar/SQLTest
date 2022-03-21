SELECT project.name,test.name,test.start_time FROM union_reporting.test
join union_reporting.project on project.id=test.project_id
where test.start_time > "2016-10-12 23:59:59"
order by project.name,test.name 