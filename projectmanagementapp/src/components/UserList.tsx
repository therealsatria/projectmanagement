import React, { useState, useEffect } from 'react';
import { User } from '../types/user';

const UserList = () => {
    const [users, setUsers] = useState<User[]>([]);
    const [loading, setLoading] = useState(true);
    const [error, setError] = useState<string | null>(null);

    useEffect(() => {
        const fetchUsers = async () => {
            try {
                await new Promise(resolve => setTimeout(resolve, 1000));

                const response = await fetch('http://localhost:5151/api/Users');
                if (!response.ok) {
                    throw new Error('Network response was not ok');
                }
                const data = await response.json();
                setUsers(data);
                setLoading(false);
            } catch (error) {
                setError('Error fetching users');
                setLoading(false);
            }
        };
        fetchUsers();
    }, []);

    if (loading) {
        return <p>Loading...</p>;
    }
    if (error) {
        return <p>{error}</p>;
    }
    return (
        <div className="user-table">
            <table>
                <thead>
                    <tr>
                        <th>Username</th>
                        <th>Email</th>
                        <th>User ID</th>
                        <th>Dibuat Pada</th>
                        <th>Diubah Pada</th>
                    </tr>
                </thead>
                <tbody>
                    {users.map((user) => (
                        <tr key={user.userId}>
                            <td>{user.username}</td>
                            <td>{user.email}</td>
                            <td>{user.userId}</td>
                            <td>{new Date(user.createdOn).toLocaleDateString()}</td>
                            <td>{new Date(user.updatedOn).toLocaleDateString()}</td>
                        </tr>
                    ))}
                </tbody>
            </table>
        </div>
    );

}

export default UserList;