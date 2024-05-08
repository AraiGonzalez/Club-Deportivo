use ClubDeportivo;
drop procedure if exists RegistrarSocioNoSocio;
delimiter //

create procedure RegistrarSocioNoSocio( in IdInscripcion int,
										in Plan varchar(10),
										out rta int)
begin
	declare filas int default 0;
    
    if Plan = "Mensual" then
		set filas = (select count(*) from Socio);
		if filas = 0 then
			/* --- Se establece 1001 como el primer id de socio --- */
			set filas = 1001;
		else
			set filas = (select max(IdSocio) + 1 from Socio);
		end if;
		insert into Socio values(filas, IdInscripcion);
		set rta = filas;
	else
		set filas = (select count(*) from NoSocio);
		if filas = 0 then
			/* --- Se establece 1001 como el primer id de socio --- */
			set filas = 1001;
		else
			set filas = (select max(IdNoSocio) + 1 from NoSocio);
		end if;
		insert into NoSocio values(filas, IdInscripcion);
		set rta = filas;
	end if;    
end
//