import React from 'react'
import { Route } from 'react-router-dom'
import UserView from '../Views/Users/UserView'
import UserDetailsView from '../Views/Users/UserDetailsView'
import UserEditView from '../Views/Users/UserEditView'

const UsersController = () => {
  return (
    <>
        <Route path="/users" element={<UserView />} />
        <Route path="/users/details/:id" element={<UserDetailsView />} />
        <Route path="/users/edit/:id" element={<UserEditView />} />
    </>
  )
}

export default UsersController