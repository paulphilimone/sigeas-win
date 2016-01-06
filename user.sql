CREATE DATABASE bi_sigeas_database;

CREATE USER 'sigeas'@'localhost' IDENTIFIED BY 's@ge_omega47';
GRANT ALL ON `bi_sigeas_database`.* TO 'sigeas'@'localhost' IDENTIFIED BY 's@ge_omega47';
GRANT ALL ON `bi_sigeas_database`.* TO 'sigeas'@'%' IDENTIFIED BY 's@ge_omega47';
flush privileges;