SELECT browser,count(*) FROM union_reporting.test
WHERE browser = "chrome"
union SELECT browser,count(*) FROM union_reporting.test
WHERE browser = "firefox"