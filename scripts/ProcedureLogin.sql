use ClubDeportivo;
drop procedure if exists IngresoLogin;
delimiter //  

/* ==================================================================== */

/* --- Procedimiento para verificar si el usuario ingresado existe 
				y devolver el rol del mismo --- */

create procedure IngresoLogin(in Usu varchar(20),in Pass varchar(15))
begin  
  select NomRol
	from usuario u inner join roles r on u.RolUsu = r.RolUsu
		where NombreUsu = Usu and PassUsu = Pass 
			and Activo = 1;
end 
//

/* ==================================================================== */