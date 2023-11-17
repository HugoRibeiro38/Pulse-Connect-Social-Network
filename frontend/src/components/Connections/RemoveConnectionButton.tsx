'use client';

import { Loader2, Unlink } from 'lucide-react';
import { Fragment } from 'react';

import { Button } from '@/components/ui/button';
import { useDeleteConnection } from '@/hooks/useConnections';

type RemoveConnectionButtonProps = {
	id: string;
};

const RemoveConnectionButton: React.FunctionComponent<
	RemoveConnectionButtonProps
> = ({ id }): React.ReactNode => {
	const { mutate, isPending } = useDeleteConnection();

	return (
		<Button disabled={isPending} onClick={() => mutate(id)}>
			{isPending ? (
				<Fragment>
					<Loader2 className='mr-2 h-4 w-4 animate-spin' />
					Disconnecting...
				</Fragment>
			) : (
				<Fragment>
					<Unlink className='mr-2 h-4 w-4' />
					Disconnect
				</Fragment>
			)}
		</Button>
	);
};

export default RemoveConnectionButton;
