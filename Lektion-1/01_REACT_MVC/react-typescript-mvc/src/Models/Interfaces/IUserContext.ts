import { UserModel } from "../UserModel";

export interface IUserContext {
    user: UserModel
    users: UserModel[]
    setUser: React.Dispatch<React.SetStateAction<UserModel>>

    create: (e: React.FormEvent) => void
    get: (id: number) => void
    getAll: () => void
    update: (e: React.FormEvent) => void
    remove: (id: number) => void
}