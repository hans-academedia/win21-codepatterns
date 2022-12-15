import React, { useContext, useState, createContext } from 'react'
import { IUserContext } from '../Models/Interfaces/IUserContext'
import { UserModel } from '../Models/UserModel'
import { UserProviderPropsModel } from '../Models/UserProviderPropsModel'

export const UserContext = createContext<IUserContext | null>(null)
export const useUserContext = () => { return useContext(UserContext) }

const UserProvider = ({children} : UserProviderPropsModel) => {
    const user_default: UserModel = { id: 0, firstName: '', lastName: '', email: ''}
    const [user, setUser] = useState(user_default)
    const [users, setUsers] = useState<UserModel[]>([])

    const create = async (e: React.FormEvent) => {}
    const get = async (id: number) => {}
    const getAll = async () => {}
    const update = async (e: React.FormEvent) => {}
    const remove = async (id: number) => {}
  
    return (
    <UserContext.Provider value={{user, setUser, users, create, get, getAll, update, remove }}>
        {children}
    </UserContext.Provider>
  )
}

export default UserProvider