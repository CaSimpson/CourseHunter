

DROP TABLE IF EXISTS Course, Prerequisites;





create table Course 
(
	courseIdAndNumber char(9),
	title varchar(70) not null, 
	numOfCredits int default 3,
	primary key (courseIdAndNumber)
);



create table Prerequisites 
(
	courseIdAndNumber char(9),
	pre_req1 char(9),
	pre_req2 char(9),
	pre_req3 char(9),
	pre_req4 char(9),
	pre_req5 char(9),
	pre_req6 char(9),
	pre_req7 char(9),
	foreign key (pre_req1) references Course(courseIdAndNumber),
	foreign key (pre_req2) references Course(courseIdAndNumber),
	foreign key (pre_req3) references Course(courseIdAndNumber),
	foreign key (pre_req4) references Course(courseIdAndNumber),
	foreign key (pre_req5) references Course(courseIdAndNumber),
	foreign key (pre_req6) references Course(courseIdAndNumber),
	foreign key (pre_req7) references Course(courseIdAndNumber),
	foreign key (courseIdAndNumber) references Course(courseIdAndNumber),
	primary key (courseIdAndNumber)	
);

create table Student 
(
	student_ID char(9),
	firstName varchar(25),
	mi char(1),
	lastName varchar(25),
	phone char(11),
	deptId char(4),
	primary key (student_ID)
);





Insert into Course  values('ENGL U101', 'Composition I',3);
Insert into Course  values('ENGL U102', 'Composition II',3);
Insert into Course  values('SPCH 201', 'Public Speaking',3);
Insert into Course  values('MATH U120', 'College Mathematics',3);
Insert into Course  values('MATH U121', 'College Algebra',3);
Insert into Course  values('MATH U126', 'Precalculus I',3);
Insert into Course  values('MATH U127', 'Precalculus II',3);
Insert into Course  values('MATH U141', 'Calculus I',4);
Insert into Course  values('MATH U142', 'Calculus II',4);
Insert into Course  values('MATH U174', 'Elements of Discrete Mathematics',4);
Insert into Course  values('BIOL U101', 'Introductory Biology I',4);
Insert into Course  values('BIOL U102', 'Introductory Biology II',4);
Insert into Course  values('CHEM U111', 'General Chemistry',4);
Insert into Course  values('CHEM U112', 'General Chemistry and Qualitative Analysis',4);
Insert into Course  values('PHYS U211', 'Essentials of Physics I',4);
Insert into Course  values('PHYS U212', 'Essentials of Physics II',4);

Insert into Course  values('CSCI U150', 'Introduction to Computer Science',3);
Insert into Course  values('CSCI U200', 'Computer Science I',3);
Insert into Course  values('CSCI U210', 'Computer Organization',3);
Insert into Course  values('CSCI U234', 'Visual BASIC Programming',3);
Insert into Course  values('CSCI U238', 'C++ Programming',3);

Insert into Course  values('CSCI U300', 'Computer Science II',3);
Insert into Course  values('CSCI U310', 'Introduction to Computer Architecture',3);
Insert into Course  values('CSCI U311', 'Information Systems Hardware and Software',3);
Insert into Course  values('CSCI U314', 'Industrial Robotics',3);

Insert into Course  values('CSCI U321', 'Computer Science III',3);
Insert into Course  values('CSCI U355', 'Digital Forensics',3);
Insert into Course  values('CSCI U370', 'Fundamentals of Bioinformatics',3);

Insert into Course  values('CSCI U399', 'Independent Study',3);
Insert into Course  values('CSCI U412', 'Computer Networks I',3);
Insert into Course  values('CSCI U421', 'Design and Analysis of Algorithms',3);
Insert into Course  values('CSCI U450', 'E-Business Web Application Development',3);


Insert into Prerequisites  values('ENGL U101', null,null,null,null,null,null,null);
Insert into Prerequisites  values('ENGL U102', 'ENGL U101',null,null,null,null,null,null);
Insert into Prerequisites  values('SPCH 201', 'ENGL U101','ENGL U102',null,null,null,null,null);
Insert into Prerequisites  values('MATH U120', null,null,null,null,null,null,null);
Insert into Prerequisites  values('MATH U121','MATH U120', null,null,null,null,null,null);
Insert into Prerequisites  values('MATH U126', null,null,null,null,null,null,null);
Insert into Prerequisites  values('MATH U127', 'MATH U126',null,null,null,null,null,null);
Insert into Prerequisites  values('MATH U141', 'MATH U126','MATH U127',null,null,null,null,null);
Insert into Prerequisites  values('MATH U142','MATH U141', 'MATH U126','MATH U127',null,null,null,null);
Insert into Prerequisites  values('MATH U174','MATH U126', null,null,null,null,null,null);
Insert into Prerequisites  values('BIOL U101', 'MATH U120',null,null,null,null,null,null);
Insert into Prerequisites  values('BIOL U102','BIOL U101', 'MATH U120',null,null,null,null,null);
Insert into Prerequisites  values('CHEM U111', 'MATH U121','MATH U120', null,null,null,null,null);
Insert into Prerequisites  values('CHEM U112','CHEM U111', 'MATH U121','MATH U120',null,null,null,null);
Insert into Prerequisites  values('PHYS U211', 'MATH U141', 'MATH U126','MATH U127',null,null,null,null);
Insert into Prerequisites  values('PHYS U212','PHYS U211', 'MATH U141', 'MATH U126','MATH U127',null,null,null);
Insert into Prerequisites  values('CSCI U150','MATH U126', null,null,null,null,null,null);
Insert into Prerequisites  values('CSCI U200','CSCI U150','MATH U126', null,null,null,null,null);
Insert into Prerequisites  values('CSCI U210','CSCI U200','CSCI U150','MATH U126', null,null,null,null);
Insert into Prerequisites  values('CSCI U238','CSCI U200','CSCI U150','MATH U126', null,null,null,null); 
Insert into Prerequisites  values('CSCI U300','CSCI U200','CSCI U150','MATH U126', 'MATH U174',null,null,null);
Insert into Prerequisites  values('CSCI U310','CSCI U210','CSCI U200','CSCI U150','MATH U126', null,null,null);
Insert into Prerequisites  values('CSCI U311','CSCI U200','CSCI U150','MATH U126', null,null,null,null);
Insert into Prerequisites  values('CSCI U314','CSCI U200','CSCI U150','MATH U126', 'MATH U127',null,null,null);
Insert into Prerequisites  values('CSCI U321','CSCI U300','CSCI U200','CSCI U150','MATH U126', 'MATH U174',null,null);
Insert into Prerequisites  values('CSCI U355','CSCI U300','CSCI U311','CSCI U200','CSCI U150','MATH U126', 'MATH U174',null);
Insert into Prerequisites  values('CSCI U370','CSCI U321','CSCI U300','CSCI U200','CSCI U150','MATH U126', 'MATH U174',null);
Insert into Prerequisites  values('CSCI U399', null,null,null,null,null,null,null);
Insert into Prerequisites  values('CSCI U412','CSCI U300','CSCI U200','CSCI U150','MATH U126', 'MATH U174',null,null);
Insert into Prerequisites  values('CSCI U421','CSCI U321','CSCI U300','CSCI U200','CSCI U150','MATH U126', 'MATH U174',null);
Insert into Prerequisites  values('CSCI U450', 'CSCI U300','CSCI U200','CSCI U150','MATH U126', 'MATH U174',null,null);

/*
select pre_req1, pre_req2, pre_req3, pre_req4, pre_req5, pre_req6, pre_req7
from prerequisites
where courseidandnumber = 'CSCI U321';

select courseIdAndNumber, count (pre_req1) + count (pre_req2) + count (pre_req3) + count (pre_req4)
+ count (pre_req5) +count (pre_req6) + count(pre_req7) AS sumofPrereq
from prerequisites
group by courseIdAndNumber
ORDER BY sumofPrereq DESC;

*/
