use ClubDeportivo;

select * from inscripcion;
select * from pago;
select * from socio;
select * from nosocio;
select * from carnet;


select distinct s.idsocio, i.nombre, i.apellido, c.vencimiento
from inscripcion i inner join socio s on i.idinscripcion = s.idinscripcion
left join carnet c on s.idsocio = c.idsocio;
/*
select s.idsocio, i.nombre, i.apellido from inscripcion i inner join socio s on i.idinscripcion = s.idinscripcion;


select i.idinscripcion, i.nombre, i.apellido, p.fecha, p.formapago, p.monto
from inscripcion i left join pago p
on i.idinscripcion = p.idinscripcion;

select c.idcarnet, concat(i.nombre, ' ', i.apellido) as nombreCompleto, c.vencimiento
from carnet c left join socio s on c.idsocio = s.idsocio
left join inscripcion i on s.idinscripcion = i.idinscripcion
where i.idinscripcion = 455;

select * from inscripcion i left join socio s on i.idinscripcion = s.idinscripcion where s.idsocio is not null;
*/