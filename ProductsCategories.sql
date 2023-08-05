select p.name as "Имя продукта", c.name as "Имя категории"
from products p
left join products_categories pc on p.id = pc.id_product
left join categories c on pc.id_category = c.id;