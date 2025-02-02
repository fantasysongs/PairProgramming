﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Collections;
using Entity;

namespace DataBase
{
    public class StudentDataset
    {
        //模拟数据库中的学生集合

        private static List<Student> studengList;


        public static List<Student> getAll()
        {
            studengList=new List<Student>();

            Student stu1 = new Student("01","201731024132", "王川");
            studengList.Add(stu1);
            Student stu2 = new Student("02","201731024227", "于丁");
            studengList.Add(stu2);

            Student stu3 = new Student("03","201731022104", "张莹");
            studengList.Add(stu3);
            Student stu4 = new Student("04","201731024101", "李楠");
            studengList.Add(stu4);

            Student stu5 = new Student("05","201731024102", "陈欣");
            studengList.Add(stu5);
            Student stu6 = new Student("06","201731024104", "马芸慧");
            studengList.Add(stu6);

            Student stu7 = new Student("07","201731024105", "汪小萍");
            studengList.Add(stu7);
            Student stu8 = new Student("08","201731024106", "母丹");
            studengList.Add(stu8);


            

            Student stu9 = new Student("09","201731024107", "马昊妍");
            studengList.Add(stu9);
            Student stu10 = new Student("10","201731024108", "李宣晓");
            studengList.Add(stu10);

            Student stu11 = new Student("11","201731024109", "李清兰");
            studengList.Add(stu11);
            Student stu12 = new Student("12","201731024110", "成湘");
            studengList.Add(stu12);

            Student stu13 = new Student("13","201731024111", "罗涵");
            studengList.Add(stu13);
            Student stu14 = new Student("14","201731024112", "肖逸菲");
            studengList.Add(stu14);

            Student stu15 = new Student("15","201731024113", "冯士坤");
            studengList.Add(stu15);
            Student stu16 = new Student("16","201731024114", "杨汶桐");
            studengList.Add(stu16);

            Student stu17 = new Student("17","201731024115", "张焱菁");
            studengList.Add(stu17);
            Student stu18 = new Student("18","201731024116", "雷槟源");
            studengList.Add(stu18);

            Student stu19 = new Student("19","201731024118", "李志");
            studengList.Add(stu19);
            Student stu20 = new Student("20","201731024119", "黄涛");
            studengList.Add(stu20);

            Student stu21 = new Student("21","201731024120", "宋杰");
            studengList.Add(stu21);
            Student stu22 = new Student("22","201731024121", "赵俊安");
            studengList.Add(stu22);


            Student stu23 = new Student("23","201731024122", "张新明");
            studengList.Add(stu23);
            Student stu24 = new Student("24","201731024123", "张旭");
            studengList.Add(stu24);

            Student stu25 = new Student("25","201731024124", "王旭");
            studengList.Add(stu25);
            Student stu26 = new Student("26","201731024125", "李朋珂");
            studengList.Add(stu26);

            Student stu27 = new Student("27","201731024126", "张微玖");
            studengList.Add(stu27);
            Student stu28 = new Student("28","201731024127", "何明钦");
            studengList.Add(stu28);

            Student stu29 = new Student("29","201731024128", "姜玖林");
            studengList.Add(stu29);
            Student stu30 = new Student("30","201731024129", "涂才森");
            studengList.Add(stu30);



            Student stu31 = new Student("31","201731024130", "陈林");
            studengList.Add(stu31);
            Student stu32 = new Student("32","201731024131", "曾正男");
            studengList.Add(stu32);

            Student stu33 = new Student("33","201731024132", "江天宇");
            studengList.Add(stu33);
            Student stu34 = new Student("34","201731024133", "魏恩博");
            studengList.Add(stu34);

            Student stu35 = new Student("35","201731024134", "邹扬锋");
            studengList.Add(stu35);
            Student stu36 = new Student("36","201731024135", "曾琅");
            studengList.Add(stu36);

            Student stu37 = new Student("37","201731024136", "周成杰");
            studengList.Add(stu37);

            Student stu38 = new Student("38","201731024137", "马驰");
            studengList.Add(stu38);

            Student stu39 = new Student("39","201731024138", "宋树钱");
            studengList.Add(stu39);
            Student stu40 = new Student("40","201731024140", "刘川");
            studengList.Add(stu40);
            Student stu41 = new Student("41","201731024142", "任星辰");
            studengList.Add(stu41);

            Student stu42 = new Student("42","201731023225", "严一笑");
            studengList.Add(stu42);
            Student stu43 = new Student("43","201731024201", "孙颖");
            studengList.Add(stu43);
            Student stu44 = new Student("44","201731024202", "吴明益");
            studengList.Add(stu44);
            Student stu45 = new Student("45","201731024203", "黄耀萱");
            studengList.Add(stu45);
            Student stu46 = new Student("46","201731024204", "王静宜");
            studengList.Add(stu46);
            Student stu47 = new Student("47","201731024205", "蔡玉蓝");
            studengList.Add(stu47);

            Student stu48 = new Student("48","201731024206", "姜仪");
            studengList.Add(stu48);

            Student stu49 = new Student("49","201731024207", "郑雪");
            studengList.Add(stu49);
            Student stu50 = new Student("50","201731024208", "刘俊");
            studengList.Add(stu50);
            Student stu51 = new Student("51","201731024209", "何玉姣");
            studengList.Add(stu51);
            Student stu52 = new Student("52","201731024210", "匡小娟");
            studengList.Add(stu52);
            Student stu53 = new Student("53","201731024211", "王春兰");
            studengList.Add(stu53);
            Student stu54 = new Student("54","201731024212", "顾毓");
            studengList.Add(stu54);
            Student stu55 = new Student("55","201731024213", "师志杰");
            studengList.Add(stu55);
            Student stu56 = new Student("56","201731024214", "许佳文");
            studengList.Add(stu56);
            Student stu57 = new Student("57","201731024215", "雷安勇");
            studengList.Add(stu57);

            Student stu58 = new Student("58","201731024216", "张伟");
            studengList.Add(stu58);


            Student stu59 = new Student("59","201731024217", "袁志杰");
            studengList.Add(stu59);
            Student stu60 = new Student("60","201731024218", "何全江");
            studengList.Add(stu60);
            Student stu61 = new Student("61","201731024219", "舒鹏飞");
            studengList.Add(stu61);
            Student stu62 = new Student("62","201731024220", "何辉");
            studengList.Add(stu62);
            Student stu63 = new Student("63","201731024221", "李全喜");
            studengList.Add(stu63);
            Student stu64 = new Student("64","201731024222", "谢凯宇");
            studengList.Add(stu64);
            Student stu65 = new Student("65","201731024225", "黄本巍");
            studengList.Add(stu65);
            Student stu66 = new Student("66","201731024226", "罗俊杰");
            studengList.Add(stu66);
            Student stu67 = new Student("67","201731024227", "何宸锐");
            studengList.Add(stu67);
            Student stu68 = new Student("68","201731024228", "付昶宇");
            studengList.Add(stu68);
            Student stu69 = new Student("69","201731024229", "傅伟鑫");
            studengList.Add(stu69);

            Student stu70 = new Student("70","201731024231", "王云飞");
            studengList.Add(stu70);

            Student stu71 = new Student("71","201731024232", "李元港");
            studengList.Add(stu71);

            Student stu72 = new Student("72","201731024233", "赵荣泽");
            studengList.Add(stu72);

            Student stu73 = new Student("73","201731024234", "吴郑浩");
            studengList.Add(stu73);

            Student stu74 = new Student("74","201731024235", "何继武");
            studengList.Add(stu74);

            Student stu75 = new Student("75","201731024236", "郑博");
            studengList.Add(stu75);

            Student stu76 = new Student("76","201731024237", "王万成");
            studengList.Add(stu76);

            Student stu77 = new Student("77","201731024238", "陈杰");
            studengList.Add(stu77);

            Student stu78 = new Student("78","201731024240", "胡志伟");
            studengList.Add(stu78);

            Student stu79 = new Student("79","201731024241", "涂林");
            studengList.Add(stu79);
            Student stu80 = new Student("80","201731024242", "孟诚成");
            studengList.Add(stu80);
            Student stu81 = new Student("81","201731032125", "廖志丹");
            studengList.Add(stu81);
            Student stu82 = new Student("82","201731131317", "杨也");
            studengList.Add(stu82);


            return studengList;
        }
    }
}
