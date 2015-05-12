create view productsuppliar
as
SELECT product.product_code,product.description,product.quantity,suppliar.suppliar_name from product  LEFT OUTER JOIN suppliar ON product.suppliar_id = suppliar.suppliar_id;