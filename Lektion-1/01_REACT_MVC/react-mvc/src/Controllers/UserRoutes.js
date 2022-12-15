import React from 'react'
import { Route } from 'react-router-dom'
import UsersView from '../Views/UsersView'

const UserRoutes = () => {
  return (
    <>
        <Route path="/users"  element={<UsersView />} />
        <Route path="/users/details/:id"/>
        <Route path="/users/edit/:id"/>
        <Route />
    </>
  )
}

export default UserRoutes