use ClubDeportivo;
drop procedure if exists RegistrarPago;
delimiter //

create procedure RegistrarPago(	in IdInscripcion int,
								in FormaPago varchar(10),
								in Plan varchar(10),
								in Monto double,
								in Cuotas int,
								in Fecha varchar(20),
                                out rta int)
begin
	declare filas int default 0;
    
	set filas = (select count(*) from Pago);
	if filas = 0 then
		/* --- Se establece 001 como el primer pago de cuota --- */
        set filas = 001;
	else
		set filas = (select max(IdPago) + 1 from Pago);
	end if;
    
    insert into Pago values(filas, IdInscripcion, FormaPago, Plan, Monto, Cuotas, Fecha);
    set rta = filas;
    
end//