import React from 'react'
import { Route } from 'react-router-dom'

const ProductRoutes = () => {
  return (
    <>
        <Route path="/products" />
        <Route path="/products/details/:id" />
        <Route path="/products/edit/:id" />
    </>
  )
}

export default ProductRoutes