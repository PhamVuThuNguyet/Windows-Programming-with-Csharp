:-discontiguous(prescription/3).
:-discontiguous(ingredients/4).
:-discontiguous(type/3).

% Base

% prescription("Salad tron uc ga",407,"").

% ingredients("Uc ga",200,"g","Salad tron uc ga").

% type("Salad tron uc ga","Sang","Giam can").

% Breakfasts

prescription("Salad tron uc ga",407,"").

ingredients("Uc ga",200,"g","Salad tron uc ga").
ingredients("Xa lach",1,"bo","Salad tron uc ga").
ingredients("Ca chua bi",4,"qua","Salad tron uc ga").
ingredients("Dau o liu",1,"muong canh","Salad tron uc ga").
ingredients("Nuoc cot chanh",2,"muong canh","Salad tron uc ga").
ingredients("Tuong ot ngot",2,"muong canh","Salad tron uc ga").

type("Salad tron uc ga","Sang","Giam can").

prescription("Banh mi den kep ca ngu",259,"").

ingredients("Banh mi den",2,"lat","Banh mi den kep ca ngu").
ingredients("Ca ngu ngam dau",200,"g","Banh mi den kep ca ngu").
ingredients("Muoi",1/5,"thia ca phe","Banh mi den kep ca ngu").
ingredients("Tieu",1/6,"thia ca phe","Banh mi den kep ca ngu").

type("Banh mi den kep ca ngu","Sang","Giam can").

prescription("Sinh to bo",160,"").

ingredients("Bo tuoi",200,"g","Sinh to bo").
ingredients("Mat ong",2,"muong canh","Sinh to bo").
ingredients("Nuoc da",2,"cup","Sinh to bo").

type("Sinh to bo","Sang","Giam can").

prescription("Pho bo",480,"").

ingredients("Thit than bo",500,"g","Pho bo").
ingredients("Xuong bo",1,"kg","Pho bo").
ingredients("Hanh tay",200,"g","Pho bo").
ingredients("Banh pho",500,"g","Pho bo").

type("Pho bo","Sang","Giu can").

prescription("Banh mi bo kho",538,"").

ingredients("Thit bo",500,"g","Banh mi bo kho").
ingredients("Ca chua",3,"qua","Banh mi bo kho").
ingredients("Ca rot",2,"cu","Banh mi bo kho").
ingredients("Khoai tay",2,"cu","Banh mi bo kho").
ingredients("Banh mi",2,"lat","Banh mi bo kho").

type("Banh mi bo kho","Sang","Giu can").

prescription("Banh canh cha ca",400,"").

ingredients("Cha ca thac lac",500,"g","Banh canh cha ca").
ingredients("Banh canh",500,"g","Banh canh cha ca").
ingredients("Xuong ong heo",1,"kg","Banh canh cha ca").

type("Banh canh cha ca","Sang","Giu can").

prescription("Xoi ga",600,"").

ingredients("Thit ga",50,"g","Xoi ga").
ingredients("Ruoc",10,"g","Xoi ga").
ingredients("Xoi nep",100,"g","Xoi ga").

type("Xoi ga","Sang","Tang can").

type("Pho bo","Sang","Tang can").

type("Banh mi bo kho","Sang","Tang can").

% Lunches

prescription("Uc ga va bong cai xanh luoc",195,"").

ingredients("Uc ga",100,"g","Uc ga va bong cai xanh luoc").
ingredients("Bong cai xanh",100,"g","Uc ga va bong cai xanh luoc").

type("Uc ga va bong cai xanh luoc","Trua","Giam can").

prescription("Salad hoa qua",190,"").

ingredients("Tao xanh",1,"qua","Salad hoa qua").
ingredients("Dua chuot",1,"qua","Salad hoa qua").
ingredients("Xa lach",1,"bo","Salad hoa qua").
ingredients("Dau tay",200,"g","Salad hoa qua").
ingredients("Sua dac",45,"g","Salad hoa qua").
ingredients("Chanh",1,"qua","Salad hoa qua").

type("Salad hoa qua","Trua","Giam can").

prescription("Ca hoi nuong",208,"").

ingredients("Ca hoi",100,"g","Ca hoi nuong").
ingredients("Mat ong",2,"thia ca phe","Ca hoi nuong").
ingredients("Bo lat",1,"mieng","Ca hoi nuong").
ingredients("Muoi",0.5,"thia ca phe","Ca hoi nuong").
ingredients("Tieu",1,"thia ca phe","Ca hoi nuong").

type("Ca hoi nuong","Trua","Giam can").

prescription("Bo xao nam",500,"").

ingredients("Thit bo tuoi",200,"g","Bo xao nam").
ingredients("Ca rot",1,"cu","Bo xao nam").
ingredients("Nam kim cham",400,"g","Bo xao nam").
ingredients("Bong cai xanh",400,"g","Bo xao nam").
ingredients("Nam dong co",50,"g","Bo xao nam").

type("Bo xao nam","Trua","Giu can").

prescription("Gio heo ham rau cu",450,"").

ingredients("Chan gio heo",800,"g","Gio heo ham rau cu").
ingredients("Hat sen",200,"g","Gio heo ham rau cu").
ingredients("Ca rot",2,"cu","Gio heo ham rau cu").
ingredients("Khoai tay",2,"cu","Gio heo ham rau cu").
ingredients("Hanh la",1,"bo","Gio heo ham rau cu").

type("Gio heo ham rau cu","Trua","Giu can").

prescription("Thit kho tieu",500,"").

ingredients("Thit heo nac",300,"g","Thit kho tieu").
ingredients("Nuoc mam",3,"muong canh","Thit kho tieu").
ingredients("Duong",1,"muong canh","Thit kho tieu").
ingredients("Tuong ot",1,"muong canh","Thit kho tieu").
ingredients("Tieu",1,"muong ca phe","Thit kho tieu").

type("Thit kho tieu","Trua","Giu can").

type("Bo xao nam","Trua","Tang can").

type("Gio heo ham rau cu","Trua","Tang can").

type("Thit kho tieu","Trua","Tang can").

prescription("Dau hu don thit sot ca",480,"").

ingredients("Dau hu chien",200,"g","Dau hu don thit sot ca").
ingredients("Thit heo nac",100,"g","Dau hu don thit sot ca").
ingredients("Ca chua",2,"qua","Dau hu don thit sot ca").

type("Dau hu don thit sot ca","Trua","Tang can").

% Dinners

type("Salad tron uc ga","Toi","Giam can").
type("Ca hoi nuong","Toi","Giam can").
type("Banh mi den kep ca ngu","Toi","Giam can").

type("Pho bo","Toi","Giu can").
type("Bo xao nam","Toi","Giu can").
type("Dau hu don thit sot ca","Toi","Giu can").

type("Dau hu don thit sot ca","Toi","Tang can").
type("Bo xao nam","Toi","Tang can").
type("Pho bo","Toi","Tang can").



%Rules

contains(T,D,R,CS,L,I,C,M):-prescription(R,CS,L),type(R,T,D),ingredients(I,C,M,R).
