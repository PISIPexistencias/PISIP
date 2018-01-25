/*==============================================================*/
/* DBMS name:      MySQL 5.0                                    */
/* Created on:     2018/01/23 14:14:40                          */
/*==============================================================*/


alter table BODEGA
   drop primary key;

drop table if exists BODEGA;

alter table CLIENTE
   drop primary key;

drop table if exists CLIENTE;

drop table if exists DETALLE_FACTURA;

drop table if exists DEVOLUCIONES;

alter table EMPLEADOS
   drop primary key;

drop table if exists EMPLEADOS;

alter table FACTURA
   drop primary key;

drop table if exists FACTURA;

alter table PRODUCTO
   drop primary key;

drop table if exists PRODUCTO;

alter table PROVEEDORES
   drop primary key;

drop table if exists PROVEEDORES;

alter table ROLES
   drop primary key;

drop table if exists ROLES;

alter table USUARIO
   drop primary key;

drop table if exists USUARIO;

drop table if exists USUARIO_ROL;

/*==============================================================*/
/* Table: BODEGA                                                */
/*==============================================================*/
create table BODEGA
(
   CODIGO_BODEGA        int not null auto_increment,
   SUCURSAL             varchar(40),
   DIRECCION_BODEGA     varchar(50),
   FONO_BODEGA          varchar(10),
   primary key (CODIGO_BODEGA)
);


/*==============================================================*/
/* Table: CLIENTE                                               */
/*==============================================================*/
create table CLIENTE
(
   ID_CLIENTE           int not null auto_increment,
   CEDULA               varchar(10),
   APELLIDOS            varchar(50),
   NOMBRES              varchar(50),
   CORREO_CLIENTE       varchar(30),
   DIRECCION_CLIENTE    varchar(50),
   TELEFONO_CLIENTE     numeric(10,0),
	primary key (ID_CLIENTE)
);


/*==============================================================*/
/* Table: DETALLE_FACTURA                                       */
/*==============================================================*/
create table DETALLE_FACTURA
(
   CODIGO_FACTURA       bigint,
   CODIGO_PRODUCTO      int,
   SECUENCIAL           int not null comment 'secuencial de los productos detallados en la factura',
   DESCRIPCION          varchar(80),
   VALOR_UNITARIO       numeric(8,2),
   VALOR_TOTAL          numeric(8,2)
);

/*==============================================================*/
/* Table: DEVOLUCIONES                                          */
/*==============================================================*/
create table DEVOLUCIONES
(
   CODIGO_PRODUCTO      int,
   CODIGO_PROVEEDOR     int,
   FECHA_DEVOLUCION     date,
   CANTIDAD_DEVUELTA    smallint,
   VALOR_DEVUELTO       numeric(8,2),
   CANTIDAD_REPUESTA    smallint,
   OBSERVACION_DEVOLUCION varchar(100)
);

/*==============================================================*/
/* Table: EMPLEADOS                                             */
/*==============================================================*/
create table EMPLEADOS
(
   CODIGO_EMPLEADO      int not null auto_increment,
   CODIGO_BODEGA        int,
   CEDULA_EMPLEADO      varchar(10),
   APELLIDOS_EMPLEADO   varchar(50),
   NOMBRES_EMPLEADO     varchar(50),
   CARGO_EMPLEADO       varchar(50),
   ESTADO_EMPLEADO      bool,
	primary key (CODIGO_EMPLEADO)
);

/*==============================================================*/
/* Table: FACTURA                                               */
/*==============================================================*/
create table FACTURA
(
   CODIGO_FACTURA       bigint not null auto_increment,
   ID_CLIENTE           int,
   FECHA_FACTURA        date,
   IVA_VALOR            numeric(8,2),
   VALOR_DEVUELTO       numeric(8,2),
   VALOR_TOTAL          numeric(8,2),
	primary key (CODIGO_FACTURA)
);


/*==============================================================*/
/* Table: PRODUCTO                                              */
/*==============================================================*/
create table PRODUCTO
(
   CODIGO_PRODUCTO      int not null auto_increment,
   CODIGO_BODEGA        int,
   CODIGO_PROVEEDOR     int,
   NOMBRE_PRODUCTO      varchar(50),
   STOCK                smallint,
   STOCK_MINIMO         smallint,
   PRECIO_COMPRA        numeric(8,2),
   PRECIO_VENTA         numeric(8,2),
   FECHA_CADUCA         date,
   ESTADO_PRODUCTO      bool,
	primary key (CODIGO_PRODUCTO)
);



/*==============================================================*/
/* Table: PROVEEDORES                                           */
/*==============================================================*/
create table PROVEEDORES
(
   CODIGO_PROVEEDOR     int not null auto_increment,
   RUC_PROVEEDOR        varchar(13),
   NOMBRE_PROVEEDOR     varchar(80),
   DIRECCION_PROVEEDOR  varchar(80),
   FONO_PROVEEDOR       varchar(10),
   CONTACTO_PROVEEDOR   varchar(50),
   ESTADO_PROVEEDOR     bool,
	primary key (CODIGO_PROVEEDOR)

);

/*==============================================================*/
/* Table: ROLES                                                 */
/*==============================================================*/
create table ROLES
(
   CODIGO_ROL           smallint not null auto_increment,
   DESCRIPCION_ROL      varchar(20),
   ESTADO_ROL           bool,
	primary key (CODIGO_ROL)
);


/*==============================================================*/
/* Table: USUARIO                                               */
/*==============================================================*/
create table USUARIO
(
   CODIGO_USUARIO       varchar(10) not null,
   CODIGO_EMPLEADO      int,
   CLAVE_USUARIO        varchar(10),
   ESTADO_USUARIO       bool,
	primary key (CODIGO_USUARIO)
);


/*==============================================================*/
/* Table: USUARIO_ROL                                           */
/*==============================================================*/
create table USUARIO_ROL
(
   CODIGO_USUARIO       varchar(10),
   CODIGO_ROL           smallint,
   ESTADO_USU_ROL       bool
);

alter table DETALLE_FACTURA add constraint FK_RELATIONSHIP_2 foreign key (CODIGO_PRODUCTO)
      references PRODUCTO (CODIGO_PRODUCTO) on delete restrict on update restrict;

alter table DETALLE_FACTURA add constraint FK_RELATIONSHIP_7 foreign key (CODIGO_FACTURA)
      references FACTURA (CODIGO_FACTURA) on delete restrict on update restrict;

alter table DEVOLUCIONES add constraint FK_RELATIONSHIP_6 foreign key (CODIGO_PRODUCTO)
      references PRODUCTO (CODIGO_PRODUCTO) on delete restrict on update restrict;

alter table DEVOLUCIONES add constraint FK_RELATIONSHIP_8 foreign key (CODIGO_PROVEEDOR)
      references PROVEEDORES (CODIGO_PROVEEDOR) on delete restrict on update restrict;

alter table EMPLEADOS add constraint FK_RELATIONSHIP_10 foreign key (CODIGO_BODEGA)
      references BODEGA (CODIGO_BODEGA) on delete restrict on update restrict;

alter table FACTURA add constraint FK_RELATIONSHIP_1 foreign key (ID_CLIENTE)
      references CLIENTE (ID_CLIENTE) on delete restrict on update restrict;

alter table PRODUCTO add constraint FK_RELATIONSHIP_4 foreign key (CODIGO_PROVEEDOR)
      references PROVEEDORES (CODIGO_PROVEEDOR) on delete restrict on update restrict;

alter table PRODUCTO add constraint FK_RELATIONSHIP_5 foreign key (CODIGO_BODEGA)
      references BODEGA (CODIGO_BODEGA) on delete restrict on update restrict;

alter table USUARIO add constraint FK_RELATIONSHIP_11 foreign key (CODIGO_EMPLEADO)
      references EMPLEADOS (CODIGO_EMPLEADO) on delete restrict on update restrict;

alter table USUARIO_ROL add constraint FK_RELATIONSHIP_12 foreign key (CODIGO_USUARIO)
      references USUARIO (CODIGO_USUARIO) on delete restrict on update restrict;

alter table USUARIO_ROL add constraint FK_RELATIONSHIP_13 foreign key (CODIGO_ROL)
      references ROLES (CODIGO_ROL) on delete restrict on update restrict;

