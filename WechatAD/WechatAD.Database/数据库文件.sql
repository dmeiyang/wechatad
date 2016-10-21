create table member
(
	Id char(32) primary key,
	Account varchar(50) not null comment '账号',
	Password varchar(100) not null comment '密码',
	DateTime datetime not null comment '入库时间'
) comment '会员表';

create table advertisement
(
	Id char(32) primary key,
	MemberId char(32) not null comment '会员Id',
	Title varchar(50) not null comment '名称',
	Material varchar(100) not null comment '素材',
	Type varchar(20) not null comment '素材类型',
	DateTime datetime not null comment '入库时间'
) comment '广告表';

create table article
(
	Id char(32) primary key,
	MemberId char(32) not null comment '会员Id',
	Content longtext not null comment '文章内容',
	DateTime datetime not null comment '入库时间'
) comment '文章表';