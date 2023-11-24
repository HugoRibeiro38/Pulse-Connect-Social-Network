type HttpMethod = 'GET' | 'POST' | 'PUT' | 'DELETE';

export const fetchData = async <T>(
	url: string,
	method: HttpMethod,
	headers?: Record<string, string>,
	body?: Record<string, unknown>,
): Promise<T> => {
	try {
		const response = await fetch(url, {
			method,
			headers: {
				Accept: 'application/json',
				'Content-Type': 'application/json',
				...headers,
			},
			body: body && JSON.stringify(body),
		});

		if (!response.ok) {
			throw new Error(
				`Error fetching data: ${response.status} ${response.statusText}`,
			);
		}

		const data = (await response.json()) as T;
		return data;
	} catch (error) {
		console.error('Error fetching data:', error);
		throw error;
	}
};
