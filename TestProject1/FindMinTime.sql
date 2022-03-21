SELECT project.name,test.name, min(test.end_time-test.start_time) 
FROM union_reporting.test
JOIN union_reporting.project on project.id=test.project_id 
GROUP BY test.name 
ORDER BY project.name,test.name