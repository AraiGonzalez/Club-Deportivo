use ClubDeportivo;
drop procedure if exists EmitirCarnet;
delimiter //

create procedure EmitirCarnet ( in SocioId int,
								in Vencimiento varchar(10),
                                out rta int)
begin
	declare filas int default 0;
    declare existe int default 0;
    
	set filas = (select count(*) from Carnet);
	if filas = 0 then
		/* --- Se establece 2001 como el primer ID de carnet --- */
        set filas = 2001;
	else
		set filas = (select max(IdCarnet) + 1 from Carnet);
        set existe = (select count(*) from Carnet where  SocioId = IdSocio);
	end if;
    
    if existe = 0 then
		insert into Carnet values(filas, SocioId, Vencimiento);
		set rta = filas;
	else
		set rta = existe;
	end if;	
end
//

