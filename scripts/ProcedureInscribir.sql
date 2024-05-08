use ClubDeportivo;
drop procedure if exists InscribirCliente;
delimiter //

/* ==================================================================== */

/* --- Procedimiento para agregar un nuevo socio a la tabla Socio (con un número de socio)
		y verificar si ya existe. Devuelve el numero de socio. --- */

 create procedure InscribirCliente(in Nom varchar(30),
							in Ape varchar(40),
							in Doc int,
                            in Apt bool,
                            out rta int)
 begin
     declare filas int default 0;
	 declare existe int default 0;
    
     set filas = (select count(*) from Inscripcion);
     if filas = 0 then
		/* --- Se establece 452 como el primer numero de socio --- */
		set filas = 452;
     else
		/* --- Se busca al ultimo numero de socio almacenado para sumarle 1
					y considerarlo asi como Primary Key --- */
		set filas = (select max(IdInscripcion) + 1 from Inscripcion);

		/* ---- Se consulta para saber si ya esta almacenado el socio --- */
		set existe = (select count(*) from Inscripcion where  Doc = DNI);
     end if;
	 
		/* --- Si no existe se lo agrega a la tabla Inscripcion --- */
	  if existe = 0 then	 
		 insert into Inscripcion values(filas,Nom,Ape,Doc,Apt);
		 set rta  = filas;
	  else
		 set rta = existe;
      end if;		 
    
     end //