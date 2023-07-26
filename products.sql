SELECT p.name, c.name
FROM products p
         left join products_categories pc
                   on pc.product_id = p.id
         left join categories c
                   on c.id = pc.category_id